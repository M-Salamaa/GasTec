using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_gastec.Models
{
    public class ListWebSectionsModel
    {
        public int WebSectionID { get; set; }
        public string WebSectionTitle { get; set; }
        public string DisplayOrder { get; set; }
        public string ActionURL { get; set; }
        public string ToolTip { get; set; }
        public string WebSection_HTM_Link { get; set; }
        public string WebSection_PlainText { get; set; }
        public List<LstImageModel> LstImages { get; set; }
    }
}
