using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_gastec.Domain
{
    public static class GetActionName
    {
        public static string GetActionNameByClassificationTreeID(int id_)
        {
            string actionName = "";
            switch (id_)
            {
                case 9:
                    actionName = "LegalEntity";
                    break;
                case 120:
                    actionName = "Members";
                    break;
                case 121:
                    actionName = "VisionMision";
                    break;
                case 122:
                    actionName = "Contributors";
                    break;
                case 123:
                    actionName = "HR";
                    break;
                case 124:
                    actionName = "Activities";
                    break;
                default:
                    actionName = "LegalEntity";
                    break;
            }
            return actionName;
        }
        public static string GetActionNameforHRSectionByID(int id_)
        {
            string actionName = "";
            switch (id_)
            {
                case 15:
                    actionName = "HR";
                    break;
                case 78:
                    actionName = "Relations";
                    break;
                case 17:
                    actionName = "Training";
                    break;
                case 18:
                    actionName = "organizational";
                    break;
                default:
                    actionName = "HR";
                    break;
            }
            return actionName;
        }
        public static string GetActionNameforCarConversionSectionByID(int id_)
        {
            string actionName = "";
            switch (id_)
            {
                case 19:
                    actionName = "Advantage";
                    break;
                case 20:
                    actionName = "Conversion_Proccess";
                    break;
                case 21:
                    actionName = "Conversion_Cost";
                    break;
                case 22:
                    actionName = "SafteyFactor";
                    break;
                case 23:
                    actionName = "CommonQuestions";
                    break;
                case 24:
                    actionName = "Conversion_Centers";
                    break;
                case 25:
                    actionName = "local_manufacturing";
                    break;
                default:
                    actionName = "Advantage";
                    break;
            }
            return actionName;
        }
        public static string GetActionNameforCylindarTestingSectionByID(int id_)
        {
            string actionName = "";
            switch (id_)
            {
                case 37:
                    actionName = "Testing_Proccess";
                    break;
                case 38:
                    actionName = "Testing_Centers";
                    break;
                case 39:
                    actionName = "Explainer_videos";
                    break;
                default:
                    actionName = "Testing_Proccess";
                    break;
            }
            return actionName;
        }
        public static string GetActionNameforCateringStationsSectionByID(int id_)
        {
            string actionName = "";
            switch (id_)
            {
                case 26:
                    actionName = "NaturalGas";
                    break;
                case 27:
                    actionName = "LiquidGas";
                    break;
                case 28:
                    actionName = "IntegratedStations";
                    break;
                case 29:
                    actionName = "TransportationProccess";
                    break;
                case 30:
                    actionName = "OccupationalSafety";
                    break;
                case 31:
                    actionName = "MobileStations";
                    break;
                default:
                    actionName = "NaturalGas";
                    break;
            }
            return actionName;
        }
        public static string GetActionNameforStatisticsSectionByID(int id_)
        {
            string actionName = "";
            switch (id_)
            {
                case 44:
                    actionName = "Stat_Gastec";
                    break;
                case 45:
                    actionName = "Stat_Egypt";
                    break;
                case 46:
                    actionName = "Stat_World";
                    break;
                default:
                    actionName = "Stat_Gastec";
                    break;
            }
            return actionName;
        }
        public static string GetActionNameforOilsSectionByID(int id_)
        {
            string actionName = "";
            switch (id_)
            {
                case 40:
                    actionName = "Agency";
                    break;
                case 41:
                    actionName = "Industrial";
                    break;
                case 42:
                    actionName = "Commercial";
                    break;
                case 43:
                    actionName = "Distributor";
                    break;
                default:
                    actionName = "Agency";
                    break;
            }
            return actionName;
        }
        public static string GetActionNameforMediaCenterSectionByID(int id_)
        {
            string actionName = "";
            switch (id_)
            {
                case 48:
                    actionName = "PhotoCenter";
                    break;
                case 49:
                    actionName = "Videos";
                    break;
                case 50:
                    actionName = "ActivitiesPhoto";
                    break;
                case 51:
                    actionName = "Reports";
                    break;
                default:
                    actionName = "PhotoCenter";
                    break;
            }
            return actionName;
        }

    }
}
