using System;
using System.IO;
using System.Text;

namespace WebApp_gastec.Domain
{
    public class System
    {
        private static string FirstSalt = "*&*$(#-j90";
        private static string SecondSalt = "($34#45(*)";
        public static string Encrypt(string TextToEncrypt_)
        {
            var ByteX = Encoding.ASCII.GetBytes(FirstSalt + TextToEncrypt_ + SecondSalt);
            return Convert.ToBase64String(ByteX);
        }
        public static string Decrypt(string TextToDecrypt_)
        {
            try
            {
                var ByteX = Convert.FromBase64String(TextToDecrypt_);
                return Encoding.ASCII.GetString(ByteX).Replace(FirstSalt, "").Replace(SecondSalt, "");
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        // Function To get sub string between two words in string
        public string Between(string STR, string FirstString, string LastString)
        {
            string FinalString;
            int Pos1 = STR.IndexOf(FirstString) + FirstString.Length;
            int Pos2 = STR.IndexOf(LastString);
            FinalString = STR.Substring(Pos1, Pos2 - Pos1);
            return FinalString;
        }
        // Function To Read Files and Return Body Tags
        public string ReadFileAsStringForBody(string fuulPath_)
        {

            using (StreamReader reader = new StreamReader(fuulPath_))
            {
                string Final;
                string line = "";
                StringBuilder stringBuilder = new StringBuilder();
                while ((line = reader.ReadLine()) != null)
                {
                    stringBuilder.Append(line);
                }
                string html_Result = stringBuilder.ToString();
                Final = Between(html_Result, "<body>", "</body>");
                return Final;
            }
        }
        // Function To Read Files and Return Style Tags
        public string ReadFileAsStringForStyle(string fuulPath_)
        {
            using (StreamReader reader = new StreamReader(fuulPath_))
            {
                string Final;
                string line = "";
                StringBuilder stringBuilder = new StringBuilder();
                while ((line = reader.ReadLine()) != null)
                {
                    stringBuilder.Append(line);
                }
                string html_Result = stringBuilder.ToString();
                Final = Between(html_Result, "<head>", "</head>");
                return Final;
            }
        }
    }
}
