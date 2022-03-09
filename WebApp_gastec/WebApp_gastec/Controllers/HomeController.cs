using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp_gastec.Models;
using WebApp_gastec.Domain;
using Microsoft.AspNetCore.Hosting;

namespace WebApp_gastec.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public readonly IWebHostEnvironment _hostingEnvironment;
        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment hostingEnvironment)
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }

        // function to Cahcing All Images Returned
        private async Task CachedAllImagesAsync(HomePageViewModel model_)
        {
            #region Caching images returned from API 
            CacheImages cacheImages = new CacheImages(_hostingEnvironment);
            //Caching main slider banners 
            foreach (var entity in model_.BannersHome)
            {
                foreach (var image in entity.LstImages)
                {
                    image.ImageGUID = await cacheImages.CahceAllImageAsync("Banners", image.ImageGUID, image.ImageLink);
                }
            }
            //Caching News Topics Section images
            foreach (var topic in model_.NewsTopics.LstNews)
            {
                if (topic.GroupID == 1 || topic.GroupID == 2)
                {
                    topic.ImageGUID = await cacheImages.CahceAllImageAsync("NewsTopics", topic.ImageGUID, topic.ImageLink);
                }
                else
                    continue;
            }
            //Caching Gastech Numbers Section images
            foreach (var listWebSection in model_.GastechNumbers)
            {
                foreach (var webSection in listWebSection.LstWebSections)
                {
                    foreach (var image in webSection.LstImages)
                    {
                        image.ImageGUID = await cacheImages.CahceAllImageAsync("GastechNumbers", image.ImageGUID, image.ImageLink);
                    }
                }
            }
            //Caching Mid Section images
            foreach (var listImage in model_.MidSection)
            {
                foreach (var image in listImage.LstImages)
                {
                    image.ImageGUID = await cacheImages.CahceAllImageAsync("MidSection", image.ImageGUID, image.ImageLink);

                }
            }
            //Caching Mid Section images
            foreach (var listImages in model_.MidBanner)
            {
                foreach (var image in listImages.LstImages)
                {
                    image.ImageGUID = await cacheImages.CahceAllImageAsync("MidBanner", image.ImageGUID, image.ImageLink);
                }
            }
            //Caching News Section images
            foreach (var image in model_.NewsSection.LstNews)
            {
                image.ImageGUID = await cacheImages.CahceAllImageAsync("NewsSection", image.ImageGUID, image.ImageLink);
            }

            foreach (var topic in model_.EniGastech.LstNews)
            {
                topic.ImageGUID = await cacheImages.CahceAllImageAsync("EniGastec", topic.ImageGUID, topic.ImageLink);
            }
            #endregion Caching images returned from API
        }
        // Caching All News Images
        private async Task CacheAllNewsImages(HomePageViewModel model_, string folderName_)
        {
            #region caching images 
            CacheImages cachedImages = new CacheImages(_hostingEnvironment);
            foreach (var entity in model_.NewsTopics.LstNews)
            {
                entity.ImageGUID = await cachedImages.CahceAllImageAsync(folderName_, entity.ImageGUID, entity.ImageLink);
            }
            #endregion
        }
        // Function to retrive Home page view Model from API
        private async Task<HomePageViewModel> GetHomeViewModelAsync()
        {
            // Create Instance for home page view model to return Main Home Page View
            HomePageViewModel homePageViewModel = new()
            {
                // Consuming Main Menu from Classification Tree API 
                MainNavigationBar = API_GetClassificationTree.GetClassificationTree(Domain.System.Encrypt("0"), Domain.System.Encrypt("0")),
                // Consuming Banners API 
                BannersHome = API_GetClassificationTree.GetClassificationTree(Domain.System.Encrypt("1"), Domain.System.Encrypt("118")),
                //Consuming Gastech Numbers Section from Classification Tree API 
                GastechNumbers = API_GetClassificationTree.GetClassificationTree(Domain.System.Encrypt("1"), Domain.System.Encrypt("349")),
                //Consuming Mid Section from Classification Tree API 
                MidSection = API_GetClassificationTree.GetClassificationTree(Domain.System.Encrypt("1"), Domain.System.Encrypt("353")),
                //Consuming Mid Banner from Classification Tree API 
                MidBanner = API_GetClassificationTree.GetClassificationTree(Domain.System.Encrypt("1"), Domain.System.Encrypt("350")),
                // Consuming Latest News API 
                NewsTopics = await API_GetNewsTopics.GetAllNewsTopics(0),
                //Consuming Service Section (Eni Gastech) from Classification Tree API 
                EniGastech = await API_GetNewsTopics.GetAllNewsTopics(3),
                //Consuming News Section from Classification Tree API 
                NewsSection = await API_GetNewsTopics.GetAllNewsTopics(4),
            };
            // Caching all images Returned in home page view model
            await CachedAllImagesAsync(homePageViewModel);
            return homePageViewModel;
        }
        private async Task<HomePageViewModel> GetNewsModel()
        {
            HomePageViewModel homePageViewModel = new()
            {
                // Consuming Main Menu from Classification Tree API 
                MainNavigationBar = API_GetClassificationTree.GetClassificationTree(Domain.System.Encrypt("0"), Domain.System.Encrypt("0")),
                // Consuming Main Cylindar Test Menu from Classification Tree API 
                Main_Section = API_GetClassificationTree.GetClassificationTree(Domain.System.Encrypt("8"), Domain.System.Encrypt("0")),
                // Consuming News Groups from Get News Topic API
                News_Group = await API_GetNewsGroup.GetNewsGroup(),
                // Consuming All News from Get News Topic API
                NewsTopics = await API_GetNewsTopics.GetAllNewsTopics(0),
            };
            return homePageViewModel;
        }
        public async Task<IActionResult> NewsAsync()
        {
            var model = await this.GetNewsModel();
            await CacheAllNewsImages(model, "MediaCenter_NewsSection");
            model.IsActive = true;
            return View(model);
        }
        // Action for home page loading
        public async Task<IActionResult> IndexAsync()
        {
            // return Model to Display in Home Page
            var model = await this.GetHomeViewModelAsync();
            return View(model);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        // Action to partial view to Display Map
        [HttpPost]
        public IActionResult _ShowMapPartial(double longtitude, double latitude)
        {
            MapLocationModel model = new MapLocationModel();
            model.longtitude = longtitude;
            model.latitude = latitude;
            return PartialView(model);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
