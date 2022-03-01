using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApp_gastec.Models;

namespace WebApp_gastec.Domain
{
    public class API_GetBannerImgInfo
    {
        // parameter for Properties of classification Settings
        private static readonly int showProperty = 1;
        // this functions to Get Banners For home Page 
        public static async Task<OutputGetBannersInfoModel> GetBannersInfoAsync(string encryptedTreeClassificationID_)
        {
            // Create instance for Save returned API Consuming
            OutputGetBannersInfoModel bannersInfo = new();
            // build new request using HTTP Client
            using (var client = new HttpClient())
            {
                // Passing Base EX APP URL 

                // Create new instance for Complete URL Request
                StringBuilder ApiUrl = new StringBuilder();

                ApiUrl.Append(Gastech_Vault.baseURL);
                // Add APi Controller, function name and Version
                ApiUrl.Append($"Main/GetBannerImgInfoV{Gastech_Vault.ApiVersion}?");
                //Add Security String
                ApiUrl.Append($"InputX.securityString={Gastech_Vault.SecurityString}");
                //Add ServerIP
                ApiUrl.Append($"&InputX.serverIP={Gastech_Vault.ServerIP}");
                //Add Database Name
                ApiUrl.Append($"&InputX.databaseName={Gastech_Vault.DatabaseName}");
                //Add Encrypted ExAppId 
                ApiUrl.Append($"&InputX.encryptedEXAppID={Gastech_Vault.EncryptedEXAppID}");
                //Add encrypted TreeNode ClassificationID
                ApiUrl.Append($"&InputX.encryptedTreeNodeClassificationID={encryptedTreeClassificationID_}");
                //Add resultCount to specify the number of returned Data
                ApiUrl.Append($"&InputX.resultCount={0}");
                //Add showFeaturedOnly
                ApiUrl.Append($"&InputX.showFeaturedOnly={showProperty}");

                // Create 
                var responseTask =await client.GetAsync(ApiUrl.ToString());
                if (responseTask.IsSuccessStatusCode)
                {
                    var response = responseTask.Content.ReadAsStringAsync().Result;
                    bannersInfo = JsonConvert.DeserializeObject<OutputGetBannersInfoModel>(response);
                }
                return bannersInfo;
            }

        }
    }
}
