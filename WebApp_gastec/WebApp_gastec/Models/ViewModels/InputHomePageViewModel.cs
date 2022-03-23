using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_gastec.Models
{
    public class InputHomePageViewModel
    {
        public List<InputGetClassificationTreeModel> BannersHome { get; set; }
        public List<InputGetClassificationTreeModel> MainNavigationBar { get; set; }
        public OutputGetNewsTopicsModel EniGastech { get; set; }
        public OutputGetNewsTopicsModel NewsSection { get; set; }
        public List<InputGetClassificationTreeModel> GastechNumbers { get; set; }
        public List<InputGetClassificationTreeModel> MidSection { get; set; }
        public List<InputGetClassificationTreeModel> MidBanner { get; set; }
        public OutputGetNewsTopicsModel NewsTopics { get; set; }
        public List<OutputGetCities> Cities { get; set; }
        public List<InputGetClassificationTreeModel> MapFiles { get; set; }
        public List<InputGetClassificationTreeModel> HR { get; set; }
        public List<InputGetClassificationTreeModel> Main_Section { get; set; }
        public List<InputGetClassificationTreeModel> Sub_Section { get; set; }
        public List<OutPutGetNewsGroupModel> News_Group { get; set; }
        public List<OutputGetNewsDetails> News_Details { get; set; }
        public ContactUsViewModel ContactUs { get; set; }
        public ConversionFormModel Car_Conversion { get; set; }
        public OutputSearchModel searchResult { get; set; }
        public SearchInputModel searchInput { get; set; }
    }
}
