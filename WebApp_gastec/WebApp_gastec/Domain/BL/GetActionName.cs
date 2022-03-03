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
                case 121:
                    actionName = "VisionMision";
                    break;
                case 124:
                    actionName = "Activities";
                    break;
                default:
                    actionName = "Index";
                    break;
            }
            return actionName;
        }
    }
}
