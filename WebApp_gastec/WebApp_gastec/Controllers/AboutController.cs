using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using WebApp_gastec.Domain;
using WebApp_gastec.Models;
namespace WebApp_gastec.Controllers
{
    public class AboutController : Controller
    {
        public readonly IWebHostEnvironment _hostingEnvironment;

        public AboutController(IWebHostEnvironment hostingEnvironment)
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
            foreach (var entity in model_.AboutUsSection)
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
            foreach (var entity in model_.AboutUsSection)
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
        // Get Model From API
        private async Task<HomePageViewModel> GetHomeViewModelAsync(string encryptedClassificationId_, string encryptedTreeClassificationId_)
        {
            // Create Instance for home page view model to return Main Home Page View
            HomePageViewModel homePageViewModel = new()
            {
                // Consuming Main Menu from Classification Tree API 
                MainNavigationBar = API_GetClassificationTree.GetClassificationTree(Domain.System.Encrypt("0"), Domain.System.Encrypt("0")),
                AboutUsSection = API_GetClassificationTree.GetClassificationTree(encryptedClassificationId_, encryptedTreeClassificationId_),
                AboutUs = API_GetClassificationTree.GetClassificationTree(Domain.System.Encrypt("125"), Domain.System.Encrypt("0")),
                HR = API_GetClassificationTree.GetClassificationTree(Domain.System.Encrypt("123"), Domain.System.Encrypt("0")),
            };
            return homePageViewModel;
        }
        // Route For Legal Entity Page
        public async Task<IActionResult> LegalEntityAsync()
        {
            var model = await this.GetHomeViewModelAsync(Domain.System.Encrypt("125"), Domain.System.Encrypt("9"));
            await CachedAllImagesAsync(model, "LegalEntity");
            await CachedAllHtmlLinksAsync(model, "LegalEntity");

            return View(model);
        }
        // Route For Vision and Mision Page
        public async Task<IActionResult> VisionMisionAsync()
        {
            var model = await this.GetHomeViewModelAsync(Domain.System.Encrypt("125"), Domain.System.Encrypt("121"));
            await CachedAllImagesAsync(model, "VisionAndMision");
            await CachedAllHtmlLinksAsync(model, "VisionAndMision");

            return View(model);
        }
        // Route For Activites Page
        public async Task<IActionResult> ActivitiesAsync()
        {
            CacheImages cachedHtml = new CacheImages(_hostingEnvironment);
            Domain.System system = new Domain.System();
            var model = await this.GetHomeViewModelAsync(Domain.System.Encrypt("125"), Domain.System.Encrypt("124"));
            await CachedAllImagesAsync(model, "Activities");
            foreach (var entity in model.AboutUsSection)
            {
                string path = await cachedHtml.CahceAllHtmlLinksAsync("Activities", entity.HTML_GUID, entity.Classification_HTMLLink);
                entity.Body = system.ReadFileAsStringForBody(path);
                entity.Style = system.ReadFileAsStringForStyle(path);
            }


            return View(model);
        }
        // Route For Members Page
        public async Task<IActionResult> MembersAsync()
        {
            var model = await this.GetHomeViewModelAsync(Domain.System.Encrypt("125"), Domain.System.Encrypt("120"));
            await CachedAllImagesAsync(model, "Members");
            await CachedAllHtmlLinksAsync(model, "Members");
            return View(model);
        }
        // Route For Human resource Page
        public async Task<IActionResult> HRAsync()
        {
            var model = await this.GetHomeViewModelAsync(Domain.System.Encrypt("123"), Domain.System.Encrypt("15"));
            await CachedAllImagesAsync(model, "Management");
            await CachedAllHtmlLinksAsync(model, "Management");
            return View(model);
        }
        // Route For  Contributors Page
        public async Task<IActionResult> ContributorsAsync()
        {
            var model = await this.GetHomeViewModelAsync(Domain.System.Encrypt("125"), Domain.System.Encrypt("122"));
            await CachedAllImagesAsync(model, "Contributors");
            await CachedAllHtmlLinksAsync(model, "Contributors");
            return View(model);
        }
        // This function is Done without any Data to view(Data in List of Web Section)
        public async Task<IActionResult> RelationsAsync()
        {
            var model = await this.GetHomeViewModelAsync(Domain.System.Encrypt("123"), Domain.System.Encrypt("78"));
            await CachedAllImagesAsync(model, "Relations");
            await CachedAllHtmlLinksAsync(model, "Relations");
            return View(model);
        }
        // Route For  Training Page
        public async Task<IActionResult> TrainingAsync()
        {
            var model = await this.GetHomeViewModelAsync(Domain.System.Encrypt("123"), Domain.System.Encrypt("17"));
            await CachedAllImagesAsync(model, "Training");
            return View(model);
        }
        // Route For  Organizitional Page
        public async Task<IActionResult> organizationalAsync()
        {
            var model = await this.GetHomeViewModelAsync(Domain.System.Encrypt("123"), Domain.System.Encrypt("18"));
            return View(model);
        }

    }
}
