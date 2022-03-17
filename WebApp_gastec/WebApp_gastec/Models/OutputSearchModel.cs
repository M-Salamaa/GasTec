using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_gastec.Models
{
    public class OutputSearchModel
    {
        public List<Search_ClassificationTreeModel> ListClassFicationTree { get; set; }
        public List<Search_NewsModel> ListNews { get; set; }
        public List<Search_VideosModel> ListVideos { get; set; }
    }
}
