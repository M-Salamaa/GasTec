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
        private void ActivateSelectedForMainCategories (HomePageViewModel model_ , string id_)
        {
            foreach (var child in model_.AboutUs)
            {
                foreach (var classification in child.LstChildClassification)
                {
                    if (classification.ClassificationID.ToString() == id_)
                        classification.IsActive = true;
                }
            }
        }
        private void ActivateSelectedForSubCategories(HomePageViewModel model_, string id_)
        {
            foreach (var child in model_.HR)
            {
                foreach (var classification in child.LstChildClassification)
                {
                    if (classification.ClassificationID.ToString() == id_)
                        classification.IsActive = true;
                }
            }
        }
        // Route For Legal Entity Page
        public async Task<IActionResult> IndexAsync(string ID_)
        {
            var model = await this.GetHomeViewModelAsync(Domain.System.Encrypt("125"), Domain.System.Encrypt(ID_));
            ActivateSelectedForMainCategories(model, ID_);
            await CachedAllImagesAsync(model, "AboutUS");
            await CachedAllHtmlLinksAsync(model, "AboutUs");

            return View(model);
        }
        // Route For Human resource Page
        public async Task<IActionResult> HumanResourcesAsync(string ID_)
        {
            var model = await this.GetHomeViewModelAsync(Domain.System.Encrypt("123"), Domain.System.Encrypt(ID_));
            ActivateSelectedForSubCategories(model, ID_);
            await CachedAllImagesAsync(model, "HumanResources");
            await CachedAllHtmlLinksAsync(model, "HumanResources");
            return View(model);
        }

    }
}
