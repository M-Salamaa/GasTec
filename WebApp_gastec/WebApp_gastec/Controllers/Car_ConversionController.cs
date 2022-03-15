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
    public class Car_ConversionController : Controller
    {
        public readonly IWebHostEnvironment _hostingEnvironment;
        public Car_ConversionController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        private void ActivateSelectedForMainCategories(HomePageViewModel model_, string id_)
        {
            foreach (var child in model_.Car_ConversionMain)
            {
                foreach (var classification in child.LstChildClassification)
                {
                    if (classification.ClassificationID.ToString() == id_)
                        classification.IsActive = true;
                }
            }
        }
        // Caching All HTML Links Returned From API via Model
        private async Task CachedAllHtmlLinksAsync(HomePageViewModel model_, string folderName_)
        {
            string path = "";
            #region Caching Html Links Returned from API
            //Create Instance from Caching Image Class
            CacheImages cachedHtml = new CacheImages(_hostingEnvironment);
            //Create Instance from System Class
            Domain.System system = new Domain.System();
            foreach (var entity in model_.Car_ConversionCategory)
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
            //Create Instance from Caching Image Class
            CacheImages cachedImages = new CacheImages(_hostingEnvironment);
            foreach (var entity in model_.Car_ConversionCategory)
            {
                // Check if there are a List of Web Sections
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
        // Get the OutPut Model after Consuming 
        private HomePageViewModel GetHomeViewModel(string encryptedClassificationId_, string encryptedTreeClassificationId_)
        {
            // Create Instance for home page view model to return Main Home Page View
            HomePageViewModel homePageViewModel = new()
            {
                // Consuming Main Navigation bar from Classification Tree API 
                MainNavigationBar = API_GetClassificationTree.GetClassificationTree(Domain.System.Encrypt("0"), Domain.System.Encrypt("0")),
                // Consuming Main Menu of Car Conversion Section from Classification Tree API 
                Car_ConversionMain = API_GetClassificationTree.GetClassificationTree(Domain.System.Encrypt("3"), Domain.System.Encrypt("0")),
                // Consuming Sub Categories of car Conversion Section from Classification Tree API 
                Car_ConversionCategory = API_GetClassificationTree.GetClassificationTree(encryptedClassificationId_, encryptedTreeClassificationId_),

            };
            return homePageViewModel;
        }
        // Routing for Car Conversion Setcion Pages with Classification ID
        public async Task<IActionResult> Index(string ID_)
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("3"), Domain.System.Encrypt(ID_));
            ActivateSelectedForMainCategories(model, ID_);
            await CachedAllImagesAsync(model, "Car_Conversion");
            await CachedAllHtmlLinksAsync(model, "Car_Conversion");
            return View(model);
        }
    }
}
