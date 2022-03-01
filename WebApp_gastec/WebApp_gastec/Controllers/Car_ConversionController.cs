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

        // Caching All HTML Links Returned From API via Model
        private async Task CachedAllHtmlLinksAsync(HomePageViewModel model_, string folderName_)
        {
            string path = "";
            #region Caching Html Links Returned from API
            CacheImages cachedHtml = new CacheImages(_hostingEnvironment);
            Domain.System system = new Domain.System();
            foreach (var entity in model_.Car_ConversionCategory)
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
            foreach (var entity in model_.Car_ConversionCategory)
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
                Car_ConversionMain = API_GetClassificationTree.GetClassificationTree(Domain.System.Encrypt("3"), Domain.System.Encrypt("0")),
                Car_ConversionCategory = API_GetClassificationTree.GetClassificationTree(encryptedClassificationId_, encryptedTreeClassificationId_),

            };
            return homePageViewModel;
        }

        public async Task<IActionResult> AdvantageAsync()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("3"), Domain.System.Encrypt("19"));
            await CachedAllImagesAsync(model, "CarConversion_Advantage");
            await CachedAllHtmlLinksAsync(model, "CarConversion_Advantage");
            return View(model);
        }
        public async Task<IActionResult> Conversion_ProccessAsync()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("3"), Domain.System.Encrypt("20"));
            await CachedAllImagesAsync(model, "Conversion_Proccess");
            await CachedAllHtmlLinksAsync(model, "Conversion_Proccess");
            return View(model);
        }
        public async Task<IActionResult> Conversion_CostAsync()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("3"), Domain.System.Encrypt("21"));
            await CachedAllImagesAsync(model, "Conversion_Cost");
            await CachedAllHtmlLinksAsync(model, "Conversion_Cost");
            return View(model);
        }
        public async Task<IActionResult> SafteyFactorAsync()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("3"), Domain.System.Encrypt("22"));
            await CachedAllImagesAsync(model, "SafteyFactor");
            await CachedAllHtmlLinksAsync(model, "SafteyFactor");
            return View(model);
        }
        public async Task<IActionResult> CommonQuestionsAsync()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("3"), Domain.System.Encrypt("23"));
            await CachedAllImagesAsync(model, "CommonQuestions");
            await CachedAllHtmlLinksAsync(model, "CommonQuestions");
            return View(model);
        }
        public async Task<IActionResult> Conversion_CentersAsync()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("3"), Domain.System.Encrypt("24"));
            await CachedAllImagesAsync(model, "Conversion_Centers");
            await CachedAllHtmlLinksAsync(model, "Conversion_Centers");
            return View(model);
        }
        public async Task<IActionResult> local_manufacturingAsync()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("3"), Domain.System.Encrypt("25"));
            await CachedAllImagesAsync(model, "local_manufacturing");
            await CachedAllHtmlLinksAsync(model, "local_manufacturing");
            return View(model);
        }
    }
}
