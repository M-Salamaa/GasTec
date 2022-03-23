using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_gastec.Domain.Enums
{
    public class GetClassificationIDByLang
    {
        static string encryptedMajorTreeID = "";

        public static void GetClassificationIdByLanguageID()
        {
            if (Gastech_Vault.TranslationLanguageID == 0)
            {
                encryptedMajorTreeID = Service.Encrypt("1");
            }
            else
            {
                encryptedMajorTreeID = Service.Encrypt("2");
            }

        }


    }
}
