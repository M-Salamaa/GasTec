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
        // Activate Selected Page in WebSite
        private void ActivateSelectedForMainCategories(HomePageViewModel model_, string id_)
        {
            foreach (var child in model_.Oil_Main)
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
            foreach (var entity in model_.Oil_Categories)
            {
                if (entity.LstWebSections.Count > 0)
                {
                    foreach (var webSection in entity.LstWebSections)
                    {
                        if (webSection.LstImages.Count > 0)
                        {
                            foreach (var image in webSection.LstImages)
                            {
                                path = await cachedHtml.CahceAllHtmlLinksAsync(folderName_, image.ImageGUID, image.HTMLLink);
                                image.Body = system.ReadFileAsStringForBody(path);
                            }
                        }
                        path = await cachedHtml.CahceAllHtmlLinksAsync(folderName_, webSection.HTML_GUID, webSection.WebSection_HTM_Link);
                        webSection.Body = system.ReadFileAsStringForBody(path);

                    }
                }
                else
                {
                    path = await cachedHtml.CahceAllHtmlLinksAsync(folderName_, entity.HTML_GUID, entity.Classification_HTMLLink);
                    entity.Body = system.ReadFileAsStringForBody(path);
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
                if (entity.LstChildClassification.Count > 0)
                {
                    foreach (var classification in entity.LstChildClassification)
                    {
                        foreach (var image in classification.LstImages)
                        {
                            image.ImageGUID = await cachedImages.CahceAllImageAsync(folderName_, image.ImageGUID, image.ImageLink);
                        }
                    }
                }
               if (entity.LstImages.Count > 0)
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
        // Routing for Exclusive Agency Page
        public async Task<IActionResult> AgencyAsync()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("6"), Domain.System.Encrypt("40"));
            ActivateSelectedForMainCategories(model, "40");
            await CachedAllImagesAsync(model, "Oil_Agency");
            await CachedAllHtmlLinksAsync(model, "Oil_Agency");
            return View(model);
        }
        // Routing for Industrial Oils Page (This Function doesn't Return the List of Child Classification)
        public async Task<IActionResult> IndustrialAsync()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("41"), Domain.System.Encrypt("0"));
            await CachedAllImagesAsync(model, "Industrial_Oil");
            ActivateSelectedForMainCategories(model, "41");
            return View(model);
        }
        // Routing for Commerical Oils Page
        public async Task<IActionResult> CommercialAsync()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("6"), Domain.System.Encrypt("42"));
            ActivateSelectedForMainCategories(model, "42");
            await CachedAllImagesAsync(model, "Commerical_Oil");
            await CachedAllHtmlLinksAsync(model, "Commerical_Oil");
            return View(model);
        }
        // Routing for Oil Distribution Page
        public async Task<IActionResult> DistributorAsync()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("6"), Domain.System.Encrypt("43"));
            ActivateSelectedForMainCategories(model, "43");
            await CachedAllImagesAsync(model, "Oil_Distributer");
            return View(model);
        }
        // Routing for Sub Commerical Oils Page
        public async Task<IActionResult> SubCommercialAsync(string OilID_)
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("6"), Domain.System.Encrypt("42"));
            model.WebSectionID = OilID_;
            await CachedAllImagesAsync(model, "Commerical_Oil");
            await CachedAllHtmlLinksAsync(model, "Commerical_Oil");
            return View(model);
        }
        // Routing for Sub Industrial Oils Page
        public async Task<IActionResult> SubIndustrialAsync(string OilID_)
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt(OilID_), Domain.System.Encrypt("0"));
            await CachedAllImagesAsync(model, "Industrial_Oil");
            await CachedAllHtmlLinksAsync(model, "Industrial_Oil");
            return View(model);
        }
    }
}
