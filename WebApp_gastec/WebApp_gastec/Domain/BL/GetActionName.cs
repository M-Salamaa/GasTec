﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_gastec.Domain
{
    public static class GetActionName
    {
        public static string GetActionNameforEniImagesByID(string id_)
        {
            string sectionID_ = "";
            switch (id_)
            {
                case "310":
                    sectionID_ = "40";
                    break;
                case "311":
                    sectionID_ = "42";
                    break;
                case "312":
                    sectionID_ = "41";
                    break;
                case "313":
                    sectionID_ = "43";
                    break;
                default:
                    sectionID_ = "40";
                    break;
            }
            return sectionID_;
        }
      

    }
}
