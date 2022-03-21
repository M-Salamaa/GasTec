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
        private void CachedAllHtmlLinks(HomePageViewModel model_, string folderName_)
        {
            string path = "";
            #region Caching Html Links Returned from API
            Cache cachedHtml = new Cache(_hostingEnvironment);
            Domain.Service system = new Domain.Service();
            foreach (var entity in model_.Main_Section)
            {
                if (entity.LstWebSections.Count > 0)
                {
                    foreach (var webSection in entity.LstWebSections)
                    {
                        path = cachedHtml.CahceAllHtmlLinks(folderName_, webSection.HTML_GUID, webSection.WebSection_HTM_Link);
                        webSection.Body = Domain.Service.ReadFileAsStringForBody(path);
                    }
                }
                else
                {
                    path = cachedHtml.CahceAllHtmlLinks(folderName_, entity.HTML_GUID, entity.Classification_HTMLLink);
                    entity.Body = Domain.Service.ReadFileAsStringForBody(path);
                }
            }
            #endregion
        }
        // Caching All Images Returned From API via Model
        private async Task CachedAllImagesAsync(HomePageViewModel model_, string folderName_)
        {
            #region Caching images returned from API 
            Cache cachedImages = new Cache(_hostingEnvironment);
            foreach (var entity in model_.Main_Section)
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
        private HomePageViewModel GetHomeViewModel(string encryptedClassificationId_, string encryptedTreeClassificationId_)
        {
            // Create Instance for home page view model to return Main Home Page View
            HomePageViewModel homePageViewModel = new()
            {
                // Consuming Main Menu from Classification Tree API 
                MainNavigationBar = API_GetClassificationTree.GetClassificationTree(Domain.Service.Encrypt("0"), Domain.Service.Encrypt("0")),
                Main_Section = API_GetClassificationTree.GetClassificationTree(encryptedClassificationId_, encryptedTreeClassificationId_),
                Sub_Section = API_GetClassificationTree.GetClassificationTree(Domain.Service.Encrypt("125"), Domain.Service.Encrypt("0")),
                HR = API_GetClassificationTree.GetClassificationTree(Domain.Service.Encrypt("123"), Domain.Service.Encrypt("0")),
            };
            return homePageViewModel;
        }
        private void ActivateSelectedForMainCategories (HomePageViewModel model_ , string id_)
        {
            foreach (var child in model_.Sub_Section)
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
            var model = this.GetHomeViewModel(Domain.Service.Encrypt("125"), Domain.Service.Encrypt(ID_));
            ActivateSelectedForMainCategories(model, ID_);
            await CachedAllImagesAsync(model, "AboutUS");
            CachedAllHtmlLinks(model, "AboutUs");

            return View(model);
        }
        // Route For Human resource Page
        public async Task<IActionResult> HumanResourcesAsync(string ID_)
        {
            var model = this.GetHomeViewModel(Domain.Service.Encrypt("123"), Domain.Service.Encrypt(ID_));
            ActivateSelectedForSubCategories(model, ID_);
            await CachedAllImagesAsync(model, "HumanResources");
            CachedAllHtmlLinks(model, "HumanResources");
            return View(model);
        }

    }
}
