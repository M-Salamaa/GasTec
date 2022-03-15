﻿using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WebApp_gastec.Models;

namespace WebApp_gastec.Domain
{
    public class CacheImages
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public CacheImages(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        // Cache All Images By Image Model and Returned the New Guid
        public async Task<string> CahceAllImageAsync(string folderName_, string imgGuid_, string dynamicLink_)
        {
            // Remove All Special Char
            imgGuid_ = ReplaceSpecialCharInImageGUID(imgGuid_);
            //Get Full Path to Search in Cach folder
            var fullPath = GetCacheFullPath(folderName_, imgGuid_);
            // Check if the Image Exist in our full Path or not 
            if (!File.Exists(fullPath))
            {
                // Convert Image Extension To Webp
                StringBuilder WebpEnv = new("http://webdev.softexservers.com/projects/imageopt/?enckey=KiYqJCgjLWo5MEwkKEZKRiQoSktGKDkqKCMoamprKCQzNCM0NSgqKQ==&onlinepath=");
                // Create Encoded URL Using our Image Dynamic Link
                string UrlEncoded = HttpUtility.UrlEncode(dynamicLink_);
                // Caching Image on server using it's Full path and it's Link
                await SaveImageAsync(fullPath, WebpEnv.Append(UrlEncoded).ToString());
            }
            return imgGuid_;
        }
        public async Task<string> CahceAllHtmlLinksAsync(string folderName_, string htmlGuid_, string htmlLink_)
        {
            // Remove All Special Char
            htmlGuid_ = ReplaceSpecialCharInHtmlGuid(htmlGuid_);
            //Get Full Path to Search in Cach folder
            var fullPath = GetCacheFullPathforHtml(folderName_, htmlGuid_);

            // Check if the Image Exist in our full Path or not 
            if (!File.Exists(fullPath))
            {
               await SaveHtmlAsync(fullPath, htmlLink_);
            }

            return fullPath;
        }
        //Replace All Special Characters in Image GUID and Finish Path with .webp
        public string ReplaceSpecialCharInImageGUID(string imgGuid_)
        {
            return imgGuid_.Replace(":", "_").Replace(" ", "").Replace("/", "_") + ".webp";
        }
        public string ReplaceSpecialCharInHtmlGuid(string htmlGuid_)
        {
            return htmlGuid_.Replace(":", "_").Replace(" ", "").Replace("/", "_") + ".html";
        }
        
        //Set Local Path for Caching images and return it
        public string GetCacheFullPath(string folderName_, string imgGuid_)
        {
            // Set Local Path in Local Machine
            string localPath = $"Images/{folderName_}/";
            // combine Root_Folder with Local_Path To get the Path for Caching
            string contentRootPath = Path.Combine(_hostingEnvironment.WebRootPath, localPath);
            // Create Directory for Cahcing images with our combined Path
            Directory.CreateDirectory(contentRootPath);
            // Return Full Path and Image GUID 
            return contentRootPath + imgGuid_;
        }
        public string GetCacheFullPathforHtml(string folderName_, string htmlGuid_)
        {
            // Set Local Path in Local Machine
            string localPath = $"HtmlFiles/{folderName_}/";
            // combine Root_Folder with Local_Path To get the Path for Caching
            string contentRootPath = Path.Combine(_hostingEnvironment.WebRootPath, localPath);
            // Create Directory for Cahcing images with our combined Path
            Directory.CreateDirectory(contentRootPath);
            // Return Full Path and Image GUID 
            return contentRootPath + htmlGuid_;
        }
        
        // Save Image on Server 
        public async Task SaveImageAsync(string fullPath_, string imageDownloadLink_)
        {
            // Create Instance for Http Client
            using var client = new HttpClient();
            // Get the Image As Bytes with GET Request to our URL
            var imageBytes = await client.GetByteArrayAsync(imageDownloadLink_);
            // Open file and Write the Bytes in
            await File.WriteAllBytesAsync(fullPath_, imageBytes);
        }
        // Save Html on Server 
        public async Task SaveHtmlAsync(string fullPath_ , string htmlLink_)
        {
            // Create Instance for Http Client
            using var client = new HttpClient();
            // Get the Image As Bytes with GET Request to our URL
            var imageBytes = await client.GetByteArrayAsync(htmlLink_);
            // Open file and Write the Bytes in
            await File.WriteAllBytesAsync(fullPath_, imageBytes);
        }
    }
}
