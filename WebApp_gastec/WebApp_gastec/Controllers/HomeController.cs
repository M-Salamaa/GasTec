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
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

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
            Cache cacheImages = new Cache(_hostingEnvironment);
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
            Cache cachedImages = new Cache(_hostingEnvironment);
            if (model_.NewsTopics.LstNews.Count > 0)
            {
                foreach (var entity in model_.NewsTopics.LstNews)
                {
                    entity.ImageGUID = await cachedImages.CahceAllImageAsync(folderName_, entity.ImageGUID, entity.ImageLink);
                }
            }
            if (model_.News_Details != null)
            {
                foreach (var entity in model_.News_Details)
                {
                    foreach (var image in entity.LstImages)
                    {
                        image.ImageGUID = await cachedImages.CahceAllImageAsync(folderName_, image.ImageGUID, image.ImageLink);
                    }
                }
            }
            #endregion
        }
        // Caching HTML for News Details
        private void CacheAllHtmlforNewsDetails(List<OutputGetNewsDetails> newsDetailsModel_, string folderName_)
        {
            string path = "";
            #region caching html 
            Cache cachedHtml = new Cache(_hostingEnvironment);
            foreach (var entitiy in newsDetailsModel_)
            {
                entitiy.Topic_Name = entitiy.Serial.ToString() + "artice";
                path = cachedHtml.CahceAllHtmlLinks(folderName_, entitiy.Topic_Name, entitiy.NewsTopic_HTMLLink);
                entitiy.body = Domain.System.ReadFileAsStringForBody(path);
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
                //Consuming Cities from GetCities API 
                Cities = await API_GetCities.GetAllCitiesAsync(),
                //Consuming Map Files from Classification Tree API
                MapFiles = await API_GetMapFiles.GetMapFilesAsync(Domain.System.Encrypt("1")),
            };
         
            return homePageViewModel;
        }
        // Function To Return View Model for All News
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
        // Function To Return View Model for News Details
        private async Task<HomePageViewModel> GetNewsDetailsModel(int serial_)
        {
            HomePageViewModel homePageViewModel = new()
            {
                // Consuming Main Menu from Classification Tree API 
                MainNavigationBar = API_GetClassificationTree.GetClassificationTree(Domain.System.Encrypt("0"), Domain.System.Encrypt("0")),
                // Consuming News Details form News Details API 
                News_Details = await API_GetNewsTopics.GetNewsDetails(serial_),
                // Consuming All News from Get News Topic API
                NewsTopics = await API_GetNewsTopics.GetAllNewsTopics(0),
            };
            return homePageViewModel;

        }
        //Action to get All News
        public async Task<IActionResult> AllNewsAsync()
        {
            var model = await this.GetNewsModel();
            await CacheAllNewsImages(model, "MediaCenter_NewsSection");
            model.IsActive = true;
            return View(model);
        }
        //Action to get News Details
        public async Task<IActionResult> NewsDetailsAsync(int serial_)
        {
            var model = await this.GetNewsDetailsModel(serial_);
            await CacheAllNewsImages(model, "News");
            CacheAllHtmlforNewsDetails(model.News_Details, "News");
            return View(model);

        }
        // Action for Index View (Home PAge)
        public async Task<IActionResult> IndexAsync()
        {
            // return Model to Display in Home Page
            var model = await this.GetHomeViewModelAsync();
            // Caching all images Returned in home page view model
            await CachedAllImagesAsync(model);
            return View(model);
        }
        // Action to partial view to Display Map
        [HttpPost]
        public async Task<IActionResult> _ShowMapPartialAsync(double longtitude, double latitude)
        {
            // Get All Json Files For Map To Cache it
            var model_ = await API_GetMapFiles.GetMapFilesAsync(Domain.System.Encrypt("1"));
            CacheAllFiles(model_);
            MapLocationModel model = new MapLocationModel();
            model.longtitude = longtitude;
            model.latitude = latitude;
            return PartialView(model);
        }
        // Action to return Json Files For Map From Specified Location with Specific Government ID
        public IActionResult ReturnJsonFile(string filepath, int government_)
        {
            string finalPath = "wwwroot/public/src/json/ar/" + filepath + ".json";
            StreamReader reader = new StreamReader(finalPath);
            if (government_ == 0)
            {
                ViewBag.JsonReturn = reader.ReadToEnd();
            }
            else
            {
                var model = JsonConvert.DeserializeObject<List<MapModel>>(reader.ReadToEnd());
                List<MapModel> newModel = new List<MapModel>();
                foreach (var item in model)
                {
                    if (item.Governorat == government_.ToString())
                    {
                        newModel.Add(item);
                    }
                }
                ViewBag.JsonReturn = JsonConvert.SerializeObject(newModel);
            }
            return PartialView("_ReturnJsonFile");
        }
        //Action For Contact US Popup
        [HttpPost]
        public ActionResult ContactUs(HomePageViewModel contactModel_)
        {
            var model = contactModel_.ContactUs;
            if (model != null)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Gastech_Vault.baseURL);
                    InputContactUsModel inputContactUsModel = new()
                    {
                        SecurityString = Gastech_Vault.SecurityString,
                        ServerIP = Gastech_Vault.ServerIP,
                        DatabaseName = Gastech_Vault.DatabaseName,
                        EncryptedEXAppID = Gastech_Vault.EncryptedEXAppID,
                        ClientIPAddress = HttpContext.Connection.RemoteIpAddress.ToString(),
                        Subject = "Contact Us:" + model.Name,
                        RequestDetails = model.Message,
                        SecurityDetails = model.Name + "\r\r\r\n" + model.Email + "\r\r\r\n" + model.PhoneNumber,
                        EncryptedPageURL = Domain.System.Encrypt(Gastech_Vault.baseURL)
                    };
                    string getContactUsInputObject = JsonConvert.SerializeObject(inputContactUsModel);
                    var httpContent = new StringContent(getContactUsInputObject, Encoding.UTF8, "application/json");
                    var responseTask = client.PostAsync("Main/AddNewContactLog", httpContent);
                    responseTask.Wait();
                    if (responseTask.Result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                        return BadRequest("Can't Submit Please Check Your Internet Connection.");
                }
            }
            return RedirectToAction("Index");

        }
        // Action For Contact US View
        public IActionResult Contacts(HomePageViewModel contactModel_)
        {
            HomePageViewModel homePageViewModel = new HomePageViewModel()
            {
                MainNavigationBar = API_GetClassificationTree.GetClassificationTree(Domain.System.Encrypt("0"), Domain.System.Encrypt("0")),
                ContactUs = contactModel_.ContactUs,
            };
            if (homePageViewModel.ContactUs != null)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Gastech_Vault.baseURL);
                    InputContactUsModel inputContactUsModel = new()
                    {
                        SecurityString = Gastech_Vault.SecurityString,
                        ServerIP = Gastech_Vault.ServerIP,
                        DatabaseName = Gastech_Vault.DatabaseName,
                        EncryptedEXAppID = Gastech_Vault.EncryptedEXAppID,
                        ClientIPAddress = HttpContext.Connection.RemoteIpAddress.ToString(),
                        Subject = "Contact Us: " + homePageViewModel.ContactUs.Name,
                        RequestDetails = homePageViewModel.ContactUs.Message,
                        SecurityDetails = homePageViewModel.ContactUs.Name + "\r\r\r\n" + homePageViewModel.ContactUs.Email + "\r\r\r\n" + homePageViewModel.ContactUs.PhoneNumber,
                        EncryptedPageURL = Domain.System.Encrypt(Gastech_Vault.baseURL)
                    };
                    string getContactUsInputObject = JsonConvert.SerializeObject(inputContactUsModel);
                    var httpContent = new StringContent(getContactUsInputObject, Encoding.UTF8, "application/json");
                    var responseTask = client.PostAsync("Main/AddNewContactLog", httpContent);
                    responseTask.Wait();
                    if (responseTask.Result.IsSuccessStatusCode)
                    {
                        homePageViewModel.ContactUs = new ContactUsViewModel();
                        return RedirectToAction("Contacts", "Home");
                    }
                    else
                        return BadRequest("Can't Submit Please Check Your Internet Connection.");
                }
            }
            return View(homePageViewModel);
        }
        // Action For Conversion Form View
        public async Task<IActionResult> Conversion_FormAsync(HomePageViewModel contactModel_)
        {
            HomePageViewModel homePageViewModel = new HomePageViewModel()
            {
                MainNavigationBar = API_GetClassificationTree.GetClassificationTree(Domain.System.Encrypt("0"), Domain.System.Encrypt("0")),
                Cities = await API_GetCities.GetAllCitiesAsync(),
                Car_Conversion = contactModel_.Car_Conversion,
            };
            Random rnd = new Random();
            homePageViewModel.ValidationNumber = rnd.Next(99999);
            if (homePageViewModel.Car_Conversion != null)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Gastech_Vault.baseURL);
                    InputContactUsModel inputCarConversionModel = new()
                    {
                        SecurityString = Gastech_Vault.SecurityString,
                        ServerIP = Gastech_Vault.ServerIP,
                        DatabaseName = Gastech_Vault.DatabaseName,
                        EncryptedEXAppID = Gastech_Vault.EncryptedEXAppID,
                        ClientIPAddress = HttpContext.Connection.RemoteIpAddress.ToString(),
                        Subject = "Conversion Request: " + homePageViewModel.Car_Conversion.Name,
                        RequestDetails = homePageViewModel.Car_Conversion.Name + "\r\r\r\n" + homePageViewModel.Car_Conversion.PhoneNumber + "\r\r\r\n" + homePageViewModel.Car_Conversion.Car_Model + "\r\r\r\n" + homePageViewModel.Car_Conversion.Car_Type +
                         "\r\r\r\n" + homePageViewModel.Car_Conversion.Country + "\r\r\r\n" + homePageViewModel.Car_Conversion.ValidationNumber,
                        SecurityDetails = homePageViewModel.Car_Conversion.Name + "\r\r\r\n" + homePageViewModel.Car_Conversion.PhoneNumber + "\r\r\r\n" + homePageViewModel.Car_Conversion.Car_Model + "\r\r\r\n" + homePageViewModel.Car_Conversion.Car_Type +
                         "\r\r\r\n" + homePageViewModel.Car_Conversion.Country + "\r\r\r\n" + homePageViewModel.Car_Conversion.ValidationNumber,
                        EncryptedPageURL = Domain.System.Encrypt(Gastech_Vault.baseURL)
                    };
                    string getCarConversionInputObject = JsonConvert.SerializeObject(inputCarConversionModel);
                    var httpContent = new StringContent(getCarConversionInputObject, Encoding.UTF8, "application/json");
                    var responseTask = client.PostAsync("Main/AddNewContactLog", httpContent);
                    responseTask.Wait();
                    if (responseTask.Result.IsSuccessStatusCode)
                    {
                        homePageViewModel.Car_Conversion = new ConversionFormModel();
                        return RedirectToAction("Conversion_Form", "Home");
                    }
                    else
                        return BadRequest("Can't Submit Please Check Your Internet Connection.");
                }
            }
            return View(homePageViewModel);
        }
        // Function To Cache All Json Files for Map
        private void CacheAllFiles(List<OutputGetClassificationTreeModel> model_)
        {
            CacheFiles cacheedFile = new CacheFiles(_hostingEnvironment);
            foreach (var entity in model_)
            {
                foreach (var file in entity.LstFiles)
                {
                    file.FileGUID = cacheedFile.CahceAllFiles(file.FileGUID, MapFileName.GetMApFileName(file.FileID), file.FileLink);
                }
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
