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
    public class Catering_StationsController : Controller
    {
        public readonly IWebHostEnvironment _hostingEnvironment;
        public Catering_StationsController(IWebHostEnvironment hostEnvironment)
        {
            _hostingEnvironment = hostEnvironment;
        }
        private void ActivateSelectedForMainCategories(HomePageViewModel model_, string id_)
        {
            foreach (var child in model_.Stations_Main)
            {
                foreach (var classification in child.LstChildClassification)
                {
                    if (classification.ClassificationID.ToString() == id_)
                        classification.IsActive = true;
                }
            }
        }
        private async Task CachedAllHtmlLinksAsync(HomePageViewModel model_, string folderName_)
        {
            string path = "";
            #region Caching Html Links Returned from API
            CacheImages cachedHtml = new CacheImages(_hostingEnvironment);
            Domain.System system = new Domain.System();
            foreach (var entity in model_.Stations_Categories)
            {
                if (entity.LstWebSections.Count > 0)
                {
                    foreach (var webSection in entity.LstWebSections)
                    {
                        path = await cachedHtml.CahceAllHtmlLinksAsync(folderName_, webSection.HTML_GUID, webSection.WebSection_HTM_Link);
                        webSection.Body = Domain.System.ReadFileAsStringForBody(path);
                    }
                }
                else
                {
                    path = await cachedHtml.CahceAllHtmlLinksAsync(folderName_, entity.HTML_GUID, entity.Classification_HTMLLink);
                    entity.Body = Domain.System.ReadFileAsStringForBody(path);
                }
            }
            #endregion
        }
        // Caching All Images Returned From API via Model
        private async Task CachedAllImagesAsync(HomePageViewModel model_, string folderName_)
        {
            #region Caching images returned from API 
            CacheImages cachedImages = new CacheImages(_hostingEnvironment);
            foreach (var entity in model_.Stations_Categories)
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
                Stations_Main = API_GetClassificationTree.GetClassificationTree(Domain.System.Encrypt("4"), Domain.System.Encrypt("0")),
                // Consuming Cylindar Category from Classification Tree API 
                Stations_Categories = API_GetClassificationTree.GetClassificationTree(encryptedClassificationId_, encryptedTreeClassificationId_),

            };
            return homePageViewModel;
        }
        // Routing For Integreated Station Category Page
        public async Task<IActionResult> Stations(string ID_)
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("4"), Domain.System.Encrypt(ID_));
            await CachedAllImagesAsync(model, "Integrated_Stations");
            await CachedAllHtmlLinksAsync(model, "Integrated_Stations");
            return View(model);
        }

        public async Task<IActionResult> Index(string ID_)
        {
            CacheImages cachedHtml = new CacheImages(_hostingEnvironment);
            var model = new HomePageViewModel();
            if (ID_ == "28")
            {
                model = this.GetHomeViewModel(Domain.System.Encrypt(ID_), Domain.System.Encrypt("0"));
                await CachedAllImagesAsync(model, "Stations");
                await CachedAllHtmlLinksAsync(model, "Stations");
                foreach (var entity in model.Stations_Categories)
                {
                    string path = await cachedHtml.CahceAllHtmlLinksAsync("Stations", entity.HTML_GUID, entity.Classification_HTMLLink);
                    entity.Body = Domain.System.ReadFileAsStringForBody(path);
                    foreach (var image in entity.LstImages)
                    {
                        image.ImageGUID = await cachedHtml.CahceAllImageAsync("Stations", image.ImageGUID, image.ImageLink);
                    }
                }
            }
            else
            {
                model = this.GetHomeViewModel(Domain.System.Encrypt("4"), Domain.System.Encrypt(ID_));
                await CachedAllImagesAsync(model, "Stations");
                await CachedAllHtmlLinksAsync(model, "Stations");
            }
            ActivateSelectedForMainCategories(model, ID_);
            return View(model);
        }
    }
}
