﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_gastec.Domain;
using WebApp_gastec.Models;

namespace WebApp_gastec.Controllers
{
    public class MediaCenterController : Controller
    {
        public string getYouTubeThumbnail(string YoutubeUrl)
        {
            string youTubeThumb = string.Empty;
            if (YoutubeUrl == "")
                return "";

            if (YoutubeUrl.IndexOf("=") > 0)
            {
                youTubeThumb = YoutubeUrl.Split('=')[1];
            }
            else if (YoutubeUrl.IndexOf("/v/") > 0)
            {
                string strVideoCode = YoutubeUrl.Substring(YoutubeUrl.IndexOf("/v/") + 3);
                int ind = strVideoCode.IndexOf("?");
                youTubeThumb = strVideoCode.Substring(0, ind == -1 ? strVideoCode.Length : ind);
            }
            else if (YoutubeUrl.IndexOf('/') < 6)
            {
                youTubeThumb = YoutubeUrl.Split('/')[3];
            }
            else if (YoutubeUrl.IndexOf('/') > 6)
            {
                youTubeThumb = YoutubeUrl.Split('/')[1];
            }

            return "http://img.youtube.com/vi/" + youTubeThumb + "/default.jpg";
        }

        private HomePageViewModel GetHomeViewModel(string encryptedClassificationId_, string encryptedTreeClassificationId_)
        {
            // Create Instance for home page view model to return Main Home Page View
            HomePageViewModel homePageViewModel = new()
            {
                // Consuming Main Menu from Classification Tree API 
                MainNavigationBar = API_GetClassificationTree.GetClassificationTree(Domain.System.Encrypt("0"), Domain.System.Encrypt("0")),
                // Consuming Main Cylindar Test Menu from Classification Tree API 
                Main_Section = API_GetClassificationTree.GetClassificationTree(Domain.System.Encrypt("8"), Domain.System.Encrypt("0")),
                // Consuming Cylindar Category from Classification Tree API 
                Sub_Section = API_GetClassificationTree.GetClassificationTree(encryptedClassificationId_, encryptedTreeClassificationId_),
            };
            return homePageViewModel;
        }
        public IActionResult PhotoCenter()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("48"), Domain.System.Encrypt("0"));
            return View(model);
        }
        public IActionResult Videos()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("8"), Domain.System.Encrypt("49"));
            return View(model);
        }
        public IActionResult ActivitiesPhoto()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("8"), Domain.System.Encrypt("50"));
            return View(model);
        }
        public IActionResult Reports()
        {
            var model = this.GetHomeViewModel(Domain.System.Encrypt("51"), Domain.System.Encrypt("0"));
            return View(model);
        }
    }
}
