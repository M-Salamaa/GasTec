using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApp_gastec.Domain
{
    public class CacheFiles
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public CacheFiles(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public Task<string> CahceAllFilesAsync(string fileGuid_)
        {
            // Remove All Special Char
            fileGuid_ = ReplaceSpecialCharInFileGuidForEmptyFile(fileGuid_);
            //Get Full Path to Search in Cach folder
            var fullPath = GetCacheFullPathforEmptyFiles(fileGuid_);

            // Check if the Image Exist in our full Path or not 
            if (!File.Exists(fullPath))
            {
                SaveEmptyFile(fullPath);
            }
            return Task.FromResult(fullPath);
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
        public string GetCacheFullPathforJsonFile(string fileName_)
        {
            // Set Local Path in Local Machine
            string localPath = $"public/src/json/ar/{fileName_}/";
            // combine Root_Folder with Local_Path To get the Path for Caching
            string contentRootPath = Path.Combine(_hostingEnvironment.WebRootPath, localPath);
            // Create Directory for Cahcing images with our combined Path
            Directory.CreateDirectory(contentRootPath);
            // Return Full Path and Image GUID 
            return contentRootPath + fileName_;
        }
        public string ReplaceSpecialCharInFileGuidForEmptyFile(string fileGuid_)
        {
            return fileGuid_.Replace(":", "_").Replace(" ", "").Replace("/", "_") + ".txt";
        }
        public void SaveEmptyFile(string fullPath_)
        {
            File.Create(fullPath_);
        }
        public async Task SaveJsonFileAsync(string fullPath_ , string fileLink_)
        {
            // Create Instance for Http Client
            using var client = new HttpClient();
            // Get the Image As Bytes with GET Request to our URL
            var imageBytes = await client.GetByteArrayAsync(fileLink_);
            // Open file and Write the Bytes in
            await File.WriteAllBytesAsync(fullPath_, imageBytes);
        }
    }
}
