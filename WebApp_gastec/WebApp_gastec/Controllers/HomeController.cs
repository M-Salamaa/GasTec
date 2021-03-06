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
using GoogleReCaptcha.V3.Interface;
using Microsoft.AspNetCore.Http;

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
                entitiy.body = Domain.Service.ReadFileAsStringForBody(path);
            }
            #endregion
        }
        // Function to retrive Home page view Model from API
        private async Task<HomePageViewModel> GetHomeViewModelAsync(int translationID_)
        {
            // Create Instance for home page view model to return Main Home Page View
            HomePageViewModel homePageViewModel = new()
            {
                // Consuming Main Menu from Classification Tree API 
                MainNavigationBar = API_GetClassificationTree.GetClassificationTree(Domain.Service.Encrypt("0"), Domain.Service.Encrypt("0"), translationID_),
                // Consuming Banners API 
                BannersHome = API_GetClassificationTree.GetClassificationTree(Domain.Service.Encrypt("1"), Domain.Service.Encrypt("118"), translationID_),
                //Consuming Gastech Numbers Section from Classification Tree API 
                GastechNumbers = API_GetClassificationTree.GetClassificationTree(Domain.Service.Encrypt("1"), Domain.Service.Encrypt("349"), translationID_),
                //Consuming Mid Section from Classification Tree API 
                MidSection = API_GetClassificationTree.GetClassificationTree(Domain.Service.Encrypt("1"), Domain.Service.Encrypt("353"), translationID_),
                //Consuming Mid Banner from Classification Tree API 
                MidBanner = API_GetClassificationTree.GetClassificationTree(Domain.Service.Encrypt("1"), Domain.Service.Encrypt("350"), translationID_),
                // Consuming Latest News API 
                NewsTopics = await API_GetNewsTopics.GetAllNewsTopics(0, translationID_),
                //Consuming Service Section (Eni Gastech) from Classification Tree API 
                EniGastech = await API_GetNewsTopics.GetAllNewsTopics(3, translationID_),
                //Consuming News Section from Classification Tree API 
                NewsSection = await API_GetNewsTopics.GetAllNewsTopics(4, translationID_),
                //Consuming Cities from GetCities API 
                Cities = await API_GetCities.GetAllCitiesAsync(translationID_),
                //Consuming Map Files from Classification Tree API
                MapFiles = await API_GetMapFiles.GetMapFilesAsync(Domain.Service.Encrypt("1"), translationID_),

            };

            return homePageViewModel;
        }
        // Function To Return View Model for All News
        private async Task<HomePageViewModel> GetNewsModel(int translationID_)
        {
            HomePageViewModel homePageViewModel = new()
            {
                // Consuming Main Menu from Classification Tree API 
                MainNavigationBar = API_GetClassificationTree.GetClassificationTree(Domain.Service.Encrypt("0"), Domain.Service.Encrypt("0"), translationID_),
                // Consuming Main Cylindar Test Menu from Classification Tree API 
                Main_Section = API_GetClassificationTree.GetClassificationTree(Domain.Service.Encrypt("8"), Domain.Service.Encrypt("0"), translationID_),
                // Consuming News Groups from Get News Topic API
                News_Group = await API_GetNewsGroup.GetNewsGroup(translationID_),
                // Consuming All News from Get News Topic API
                NewsTopics = await API_GetNewsTopics.GetAllNewsTopics(0, translationID_),
            };
            return homePageViewModel;
        }
        // Function To Return View Model for News Details
        private async Task<HomePageViewModel> GetNewsDetailsModel(int serial_,int translationID_)
        {
            HomePageViewModel homePageViewModel = new()
            {
                // Consuming Main Menu from Classification Tree API 
                MainNavigationBar = API_GetClassificationTree.GetClassificationTree(Domain.Service.Encrypt("0"), Domain.Service.Encrypt("0"), translationID_),
                // Consuming News Details form News Details API 
                News_Details = await API_GetNewsTopics.GetNewsDetails(serial_, translationID_),
                // Consuming All News from Get News Topic API
                NewsTopics = await API_GetNewsTopics.GetAllNewsTopics(0, translationID_),
            };
            return homePageViewModel;

        }
        //Action to get All News
        public async Task<IActionResult> AllNewsAsync()
        {
            var model = await this.GetNewsModel(int.Parse(HttpContext.Session.GetString("Localization")));
            await CacheAllNewsImages(model, "MediaCenter_NewsSection");
            model.IsActive = true;
            return View(model);
        }
        //Action to get News Details
        public async Task<IActionResult> NewsDetailsAsync(int serial_)
        {
            var model = await this.GetNewsDetailsModel(serial_, int.Parse(HttpContext.Session.GetString("Localization")));
            await CacheAllNewsImages(model, "News");
            CacheAllHtmlforNewsDetails(model.News_Details, "News");
            return View(model);

        }

        public IActionResult Translation()
        {
            Gastech_Vault.TranslationLanguageID = 1;
            return RedirectToAction("Index");
        }
        // Action for Index View (Home PAge)
        public async Task<IActionResult> IndexAsync()
        {
            SessionHelper.SetObjectAsJson(HttpContext.Session, "Localization", Gastech_Vault.TranslationLanguageID);
            var test = HttpContext.Session.GetString("Localization");
            // return Model to Display in Home Page
            var model = await this.GetHomeViewModelAsync(int.Parse(HttpContext.Session.GetString("Localization")));
            // Caching all images Returned in home page view model
            await CachedAllImagesAsync(model);
            return View(model);
        }
        // Action to partial view to Display Map
        [HttpPost]
        public async Task<IActionResult> _ShowMapPartialAsync(double longtitude, double latitude)
        {
            SessionHelper.SetObjectAsJson(HttpContext.Session, "Localization", Gastech_Vault.TranslationLanguageID);

            // Get All Json Files For Map To Cache it
            var model_ = await API_GetMapFiles.GetMapFilesAsync(Domain.Service.Encrypt("1"), int.Parse(HttpContext.Session.GetString("Localization")));
            CacheAllFiles(model_);
            MapLocationModel model = new MapLocationModel();
            model.longtitude = longtitude;
            model.latitude = latitude;
            return PartialView(model);
        }
        // Action to return Json Files For Map From Specified Location with Specific Government ID
        public IActionResult ReturnJsonFile(string filepath, int government_)
        {
            SessionHelper.SetObjectAsJson(HttpContext.Session, "Localization", Gastech_Vault.TranslationLanguageID);

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
            SessionHelper.SetObjectAsJson(HttpContext.Session, "Localization", Gastech_Vault.TranslationLanguageID);

            HomePageViewModel homePageViewModel = new HomePageViewModel()
            {
                MainNavigationBar = API_GetClassificationTree.GetClassificationTree(Domain.Service.Encrypt("0"), Domain.Service.Encrypt("0"), int.Parse(HttpContext.Session.GetString("Localization"))),
                ContactUs = contactModel_.ContactUs,
            };
            if (homePageViewModel.ContactUs != null)
            {
                // Return reCAPTCHA Response as String
                string captchaResponse = HttpContext.Request.Form["g-Recaptcha-Response"];
                // Return Captcha Response Model using IsValid Function
                CaptchaResponseViewModel result = Service.IsValid(captchaResponse);
                if (result.Success)
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
                            Subject = "Contact Us",
                            RequestDetails = homePageViewModel.ContactUs.Message,
                            SecurityDetails = homePageViewModel.ContactUs.Name + "\r\r\r\n" + homePageViewModel.ContactUs.Email + "\r\r\r\n" + homePageViewModel.ContactUs.PhoneNumber,
                            EncryptedPageURL = Domain.Service.Encrypt(Gastech_Vault.baseURL)
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
            }
            return RedirectToAction("Index");

        }
        // Action For Contact US View
        public IActionResult Contacts(HomePageViewModel contactModel_)
        {
            SessionHelper.SetObjectAsJson(HttpContext.Session, "Localization", Gastech_Vault.TranslationLanguageID);

            HomePageViewModel homePageViewModel = new HomePageViewModel()
            {
                MainNavigationBar = API_GetClassificationTree.GetClassificationTree(Domain.Service.Encrypt("0"), Domain.Service.Encrypt("0"), int.Parse(HttpContext.Session.GetString("Localization"))),
                ContactUs = contactModel_.ContactUs,
            };
            if (homePageViewModel.ContactUs != null)
            {
                // Return reCAPTCHA Response as String
                string captchaResponse = HttpContext.Request.Form["g-Recaptcha-Response"];
                // Return Captcha Response Model using IsValid Function
                CaptchaResponseViewModel result = Service.IsValid(captchaResponse);
                if (result.Success)
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
                            Subject = "Contact Us",
                            RequestDetails = homePageViewModel.ContactUs.Message,
                            SecurityDetails = homePageViewModel.ContactUs.Name + "\r\r\r\n" + homePageViewModel.ContactUs.Email + "\r\r\r\n" + homePageViewModel.ContactUs.PhoneNumber,
                            EncryptedPageURL = Domain.Service.Encrypt(Gastech_Vault.baseURL)
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
            }
            return View(homePageViewModel);
        }
        // Action For Conversion Form View
        public async Task<IActionResult> Conversion_FormAsync(HomePageViewModel contactModel_)
        {
            SessionHelper.SetObjectAsJson(HttpContext.Session, "Localization", Gastech_Vault.TranslationLanguageID);

            HomePageViewModel homePageViewModel = new HomePageViewModel()
            {
                MainNavigationBar = API_GetClassificationTree.GetClassificationTree(Domain.Service.Encrypt("0"), Domain.Service.Encrypt("0"), int.Parse(HttpContext.Session.GetString("Localization"))),
                Cities = await API_GetCities.GetAllCitiesAsync(int.Parse(HttpContext.Session.GetString("Localization"))),
                Car_Conversion = contactModel_.Car_Conversion,
            };

            if (homePageViewModel.Car_Conversion != null)
            {
                // Return reCAPTCHA Response as String
                string captchaResponse = HttpContext.Request.Form["g-Recaptcha-Response"];
                // Return Captcha Response Model using IsValid Function
                CaptchaResponseViewModel result = Service.IsValid(captchaResponse);
                if (result.Success)
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
                            Subject = "Conversion Request",
                            RequestDetails = homePageViewModel.Car_Conversion.Name + "\r\r\r\n" + homePageViewModel.Car_Conversion.PhoneNumber + "\r\r\r\n" + homePageViewModel.Car_Conversion.Car_Model + "\r\r\r\n" + homePageViewModel.Car_Conversion.Car_Type +
                             "\r\r\r\n" + homePageViewModel.Car_Conversion.Country,
                            SecurityDetails = homePageViewModel.Car_Conversion.Name + "\r\r\r\n" + homePageViewModel.Car_Conversion.PhoneNumber + "\r\r\r\n" + homePageViewModel.Car_Conversion.Car_Model + "\r\r\r\n" + homePageViewModel.Car_Conversion.Car_Type +
                             "\r\r\r\n" + homePageViewModel.Car_Conversion.Country,
                            EncryptedPageURL = Domain.Service.Encrypt(Gastech_Vault.baseURL)
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
        // Action For Search View
        public async Task<IActionResult> SearchResult(HomePageViewModel model_)
        {
            SessionHelper.SetObjectAsJson(HttpContext.Session, "Localization", Gastech_Vault.TranslationLanguageID);

            var model = new HomePageViewModel()
            {
                // Consuming Main Menu from Classification Tree API 
                MainNavigationBar = API_GetClassificationTree.GetClassificationTree(Domain.Service.Encrypt("0"), Domain.Service.Encrypt("0"), int.Parse(HttpContext.Session.GetString("Localization"))),
                // Consuming Search Result using Key Word
                searchResult = await API_GetSearchResult.GetSearchResult(model_.searchInput.keyWord_, int.Parse(HttpContext.Session.GetString("Localization"))),
            };
            return View(model);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
