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
    public class API_GetMapOfStations
    {
        private static readonly string encryptedLinkedEntityId = Domain.System.Encrypt("1");
        private static readonly string encryptedLinkedEntityType = System.Encrypt("126");

        public static List<MapModel> GetMapOfStations(string fileName_,int governmentId_)
        {
            List<MapModel> mapModel = new List<MapModel>();
            using (var client = new HttpClient())
            {
                //Create Base Addres
                client.BaseAddress = new Uri(Gastech_Vault.baseURL);
                InputGetMapOfStations getClassificationInputObject = new()
                {
                    SecurityString = Gastech_Vault.SecurityString,
                    ServerIP = Gastech_Vault.ServerIP,
                    DatabaseName = Gastech_Vault.DatabaseName,
                    EncryptedEXAppID = Gastech_Vault.EncryptedEXAppID,
                    EncryptedLinkedEntityID = encryptedLinkedEntityId,
                    EncryptedLinkedEntityType = encryptedLinkedEntityType,
                    FileName = fileName_,
                    GovernorateID = governmentId_

                };
                string getClassificationInputJson = JsonConvert.SerializeObject(getClassificationInputObject);
                var httpContent = new StringContent(getClassificationInputJson, Encoding.UTF8, "application/json");
                var responseTask = client.PostAsync("Parser/MapOfStations", httpContent);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync().Result;
                    mapModel = JsonConvert.DeserializeObject<List<MapModel>>(response);
                }
                return mapModel;
            }
        }
    }
}
