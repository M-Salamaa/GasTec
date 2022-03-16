using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApp_gastec.Models;

namespace WebApp_gastec.Domain
{
    public class CacheFiles
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public CacheFiles(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public string CahceAllFiles(string fileGuid_, string jsonFileName_, string fileLink_)
        {
            // Remove All Special Char
            fileGuid_ = ReplaceSpecialCharInFileGuidForEmptyFile(fileGuid_);
            //Get Full Path to Search in Cach folder
            var fullPathForTextFile = GetCacheFullPathforEmptyFiles(fileGuid_);

            // Check if the Image Exist in our full Path or not 
            if (!File.Exists(fullPathForTextFile))
            {
                GetCacheFullPathforJsonFile(jsonFileName_, fileLink_);
                File.Create(fullPathForTextFile);
            }
            return fullPathForTextFile;
        }
        public string GetCacheFullPathforEmptyFiles(string fileGuid_)
        {
            // Set Local Path in Local Machine
            string localPath = $"public/src/json/ar/";
            // combine Root_Folder with Local_Path To get the Path for Caching
            string contentRootPath = Path.Combine(_hostingEnvironment.WebRootPath, localPath);
            // Create Directory for Cahcing images with our combined Path
            Directory.CreateDirectory(contentRootPath);
            // Return Full Path and Image GUID 
            return contentRootPath + fileGuid_;
        }
        public void GetCacheFullPathforJsonFile(string fileName_, string fileLink_)
        {
            // Set Local Path in Local Machine
            string localPath = $"public/src/json/ar/{fileName_}";
            // combine Root_Folder with Local_Path To get the Path for Caching
            string contentRootPath = Path.Combine(_hostingEnvironment.WebRootPath, localPath);
            // Create Directory for Cahcing images with our combined Path
            string backupFile = contentRootPath + ".bak";
            if (!File.Exists(contentRootPath))
            {
                // Create New File 
                File.Create(contentRootPath);
                // Create Instance for Http Client
                using var client = new WebClient();
                // Get the Image As Bytes with GET Request to our URL
                string jsonFileContent = client.DownloadString(fileLink_);
                var model = JsonConvert.DeserializeObject<List<MapModel>>(jsonFileContent);
                File.WriteAllText(contentRootPath, JsonConvert.SerializeObject(model));

            }
            else
            {
                // Create Instance for Web Client
                using var client = new WebClient();
                // Get the Image As Bytes with GET Request to our URL
                var jsonFileContent = client.DownloadString(fileLink_);
                // Write All Json Content to the file as String
                File.WriteAllTextAsync(contentRootPath, jsonFileContent);
                // Over write the Existing File with the new one
                File.Replace(contentRootPath, contentRootPath, backupFile);
            }
        }
        public string ReplaceSpecialCharInFileGuidForEmptyFile(string fileGuid_)
        {
            return fileGuid_.Replace(":", "_").Replace(" ", "").Replace("/", "_") + ".txt";
        }
        public void SaveEmptyFile(string fullPath_)
        {
            File.Create(fullPath_);
        }
        public async Task SaveJsonFileAsync(string fullPath_, string fileLink_)
        {
            // Create Instance for Http Client
            using var client = new HttpClient();
            // Get the Image As Bytes with GET Request to our URL
            var jsonStr = await client.GetStringAsync(fileLink_);
            var model = JsonConvert.DeserializeObject<List<MapModel>>(jsonStr);
            var newmodel = JsonConvert.SerializeObject(model);
            await File.WriteAllTextAsync(fullPath_, newmodel);
        }
    }
}
