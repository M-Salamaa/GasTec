using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_gastec.Domain.Enums
{
    public class MapFileName
    {
        public static string GetMApFileName(int fileID_)
        {
            string fileName = "";
            switch(fileID_)
            {
                case 245:
                    fileName = "convert-centers";
                    break;
                case 256:
                    fileName = "cylinder-test";
                    break;
                case 257:
                    fileName = "gas-station";
                    break;
                case 258:
                    fileName = "oil-distribution";
                    break;  
                case 259:
                    fileName = "petrol-station";
                    break;
            }
            return fileName;
        }
    }
}
