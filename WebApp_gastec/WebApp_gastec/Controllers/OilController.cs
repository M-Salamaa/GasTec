using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_gastec.Domain;
using WebApp_gastec.Models;

namespace WebApp_gastec.Controllers
{
    public class OilController : Controller
    {
        public readonly IWebHostEnvironment _hostingEnvironment;
        public OilController(IWebHostEnvironment hostingEnviroment)
        {
            _hostingEnvironment = hostingEnviroment;
        }
        private async Task CachedAllHtmlLinksAsync(HomePageViewModel model_, string folderName_)
        {
            string path = "";
            #region Caching Html Links Returned from API
            CacheImages cachedHtml = new CacheImages(_hostingEnvironment);
            Domain.System system = new Domain.System();
            foreach (var entity in model_.Oil_Categories)
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
            foreach (var entity in model_.Oil_Categories)
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
                else
                {
                    foreach (var image in entity.LstImages)
                    {
                        image.ImageGUID = await cachedImages.CahceAllImageAsync(folderName_, image.ImageGUID, image.ImageLink);
                    }
                }
            }
            #endregion Caching images returned from API
        }
        // Return Data Model after Consuming API
        private HomePageViewModel GetHomeViewModel(string encryptedClassificationId_, string encryptedTreeClassificationId_)
        {
            // Create Instance for home page view model to return Main Home Page View
            HomePageViewModel homePageViewModel = new()
            {
                // Consuming Main Menu from Classification Tree API 
                MainNavigationBar = API_GetClassificationTree.GetClassificationTree(Domain.System.Encrypt("0"), Domain.System.Encrypt("0")),
                // Consuming Main Cylindar Test Menu from Classification Tree API 
                Oil_Main = API_GetClassificationTree.GetClassificationTree(Domain.System.Encrypt("6"), Domain.System.Encrypt("0")),
                // Consuming Cylindar Category from Classification Tree API 
                Oil_Categories = API_GetClassificationTree.GetClassificationTree(encryptedClassificationId_, encryptedTreeClassificationId_),

            };
            return homePageViewModel;
        }

        public async Task<IActionResult> AgencyAsync()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("6"), Domain.System.Encrypt("40"));
            await CachedAllImagesAsync(model, "Oil_Agency");
            await CachedAllHtmlLinksAsync(model, "Oil_Agency");
            return View(model);
        }

        public async Task<IActionResult> DistributorAsync()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("6"), Domain.System.Encrypt("43"));
            await CachedAllImagesAsync(model, "Oil_Distributer");
            return View(model);
        }

        public async Task<IActionResult> CommercialAsync()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("6"), Domain.System.Encrypt("42"));
            await CachedAllImagesAsync(model, "Commerical_Oil");
            await CachedAllHtmlLinksAsync(model, "Commerical_Oil");
                return View(model);
        }
    }
}
