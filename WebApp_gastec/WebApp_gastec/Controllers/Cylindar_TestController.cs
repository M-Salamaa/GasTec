﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_gastec.Domain;
using WebApp_gastec.Models;

namespace WebApp_gastec.Controllers
{
    public class Cylindar_TestController : Controller
    {
        public readonly IWebHostEnvironment _hostingEnvironment;

        public Cylindar_TestController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        private async Task CachedAllHtmlLinksAsync(HomePageViewModel model_, string folderName_)
        {
            string path = "";
            #region Caching Html Links Returned from API
            CacheImages cachedHtml = new CacheImages(_hostingEnvironment);
            Domain.System system = new Domain.System();
            foreach (var entity in model_.Cylindar_Test_Categories)
            {
                if (entity.LstWebSections.Count > 0)
                {
                    foreach (var webSection in entity.LstWebSections)
                    {
                        path = await cachedHtml.CahceAllHtmlLinksAsync(folderName_, webSection.HTML_GUID, webSection.WebSection_HTM_Link);
                        webSection.Body = system.ReadFileAsStringForBody(path);
                        webSection.Style = system.ReadFileAsStringForStyle(path);
                    }
                }
                else
                {
                    path = await cachedHtml.CahceAllHtmlLinksAsync(folderName_, entity.HTML_GUID, entity.Classification_HTMLLink);
                    entity.Body = system.ReadFileAsStringForBody(path);
                    entity.Style = system.ReadFileAsStringForStyle(path);
                }
            }
            #endregion
        }
        // Caching All Images Returned From API via Model
        private async Task CachedAllImagesAsync(HomePageViewModel model_, string folderName_)
        {
            #region Caching images returned from API 
            CacheImages cachedImages = new CacheImages(_hostingEnvironment);
            foreach (var entity in model_.Cylindar_Test_Categories)
            {
                if (entity.LstWebSections.Count > 0)
                {
                    foreach (var webSection in entity.LstWebSections)
                    {
                        foreach (var image in webSection.LstImages)
                        {
                            image.ImageGUID = await cachedImages.CahceAllImageAsync(folderName_, image.ImageGUID, image.ImageLink);

                        }
                    }
                }
                foreach (var image in entity.LstImages)
                {
                    image.ImageGUID = await cachedImages.CahceAllImageAsync(folderName_, image.ImageGUID, image.ImageLink);
                }
            }
            #endregion Caching images returned from API
        }
        private HomePageViewModel GetHomeViewModel(string encryptedClassificationId_, string encryptedTreeClassificationId_)
        {
            // Create Instance for home page view model to return Main Home Page View
            HomePageViewModel homePageViewModel = new()
            {
                // Consuming Main Menu from Classification Tree API 
                MainNavigationBar = API_GetClassificationTree.GetClassificationTree(Domain.System.Encrypt("0"), Domain.System.Encrypt("0")),
                Cylindar_Test_Main = API_GetClassificationTree.GetClassificationTree(Domain.System.Encrypt("5"), Domain.System.Encrypt("0")),
                Cylindar_Test_Categories = API_GetClassificationTree.GetClassificationTree(encryptedClassificationId_, encryptedTreeClassificationId_),

            };
            return homePageViewModel;
        }
        public async Task<IActionResult> Testing_ProccessAsync()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("5"), Domain.System.Encrypt("37"));
            await CachedAllImagesAsync(model, "Testing_Proccess");
            await CachedAllHtmlLinksAsync(model, "Testing_Proccess");
            return View(model);
        }
    }
}
