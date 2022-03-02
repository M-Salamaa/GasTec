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

        public async Task<IActionResult> NaturalGasAsync()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("4"), Domain.System.Encrypt("26"));
            await CachedAllImagesAsync(model, "NaturalGas_Stations");
            await CachedAllHtmlLinksAsync(model, "NaturalGas_Stations");
            return View(model);
        }
        public async Task<IActionResult> LiquidGasAsync()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("4"), Domain.System.Encrypt("27"));
            await CachedAllImagesAsync(model, "LiquidGas_Stations");
            await CachedAllHtmlLinksAsync(model, "LiquidGas_Stations");
            return View(model);
        }
        // This for Integrated Stations Section (It's Not Complete yet)
        public async Task<IActionResult> IntegratedStationsAsync()
        {
            CacheImages cachedHtml = new CacheImages(_hostingEnvironment);
            Domain.System system = new Domain.System();
            var model = this.GetHomeViewModel(Domain.System.Encrypt("4"), Domain.System.Encrypt("28"));
            await CachedAllImagesAsync(model, "Integrated_Stations");
            foreach (var entity in model.Stations_Categories)
            {
                string path = await cachedHtml.CahceAllHtmlLinksAsync("Integrated_Stations", entity.HTML_GUID, entity.Classification_HTMLLink);
                entity.Body = system.ReadFileAsStringForBody(path);
                entity.Style = system.ReadFileAsStringForStyle(path);
                foreach (var image in entity.LstImages)
                {
                    image.ImageGUID = await cachedHtml.CahceAllImageAsync("Integrated_Stations", image.ImageGUID, image.ImageLink);
                }
            }
            return View(model);
        }
        public async Task<IActionResult> TransportationProccessAsync()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("4"), Domain.System.Encrypt("29"));
            await CachedAllImagesAsync(model, "Transportation_Proccess");
            await CachedAllHtmlLinksAsync(model, "Transportation_Proccess");
            return View(model);
        }

        public async Task<IActionResult> OccupationalSafetyAsync()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("4"), Domain.System.Encrypt("30"));
            await CachedAllImagesAsync(model, "Occupational_Safety");
            await CachedAllHtmlLinksAsync(model, "Occupational_Safety");
            return View(model);
        }
        public async Task<IActionResult> MobileStationsAsync()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("4"), Domain.System.Encrypt("31"));
            await CachedAllImagesAsync(model, "Mobile_Stations");
            await CachedAllHtmlLinksAsync(model, "Mobile_Stations");
            return View(model);
        }
    }
}
