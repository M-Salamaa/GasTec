using System.Collections.Generic;

namespace WebApp_gastec
{
    public class OutputSearchModel
    {
        public List<SearchClassFicationTreeModel> ListClassFicationTree { get; set; }
        public List<SearchListNewsModel> ListNews { get; set; }
        public List<SearchListVideosModel> ListVideos { get; set; }
    }
}
