using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_gastec.Domain;

namespace WebApp_gastec.Models
{
    public class HomePageViewModel
    {
        public List<OutputGetClassificationTreeModel> BannersHome { get; set; }
        public List<OutputGetClassificationTreeModel> MainNavigationBar { get; set; }
        public OutputGetNewsTopicsModel EniGastech { get; set; }
        public OutputGetNewsTopicsModel NewsSection { get; set; }
        public List<OutputGetClassificationTreeModel> GastechNumbers { get; set; }
        public List<OutputGetClassificationTreeModel> MidSection { get; set; }
        public List<OutputGetClassificationTreeModel> MidBanner { get; set; }
        public OutputGetNewsTopicsModel NewsTopics { get; set; }
        // *********************************************************************** 
        public List<OutputGetClassificationTreeModel> AboutUs { get; set; }
        public List<OutputGetClassificationTreeModel> AboutUsSection { get; set; }
        public List<OutputGetClassificationTreeModel> HR { get; set; }
        // *********************************************************************** 
        public List<OutputGetClassificationTreeModel> Car_ConversionMain { get; set; }
        public List<OutputGetClassificationTreeModel> Car_ConversionCategory { get; set; }
        // *********************************************************************** 
        public List<OutputGetClassificationTreeModel> Cylindar_Test_Main { get; set; }
        public List<OutputGetClassificationTreeModel> Cylindar_Test_Categories { get; set; }
        // *********************************************************************** 
        public List<OutputGetClassificationTreeModel> Stations_Main { get; set; }
        public List<OutputGetClassificationTreeModel> Stations_Categories { get; set; }

        // *********************************************************************** 
        public List<OutputGetClassificationTreeModel> Statistics_Main{ get; set; }
        public List<OutputGetClassificationTreeModel> Statistics_Categories { get; set; }
        // *********************************************************************** 
        public List<OutputGetClassificationTreeModel> Oil_Main { get; set; }
        public List<OutputGetClassificationTreeModel> Oil_Categories { get; set; }
        // *********************************************************************** 
        public List<OutputGetClassificationTreeModel> Main_Section { get; set; }
        public List<OutputGetClassificationTreeModel> Sub_Section { get; set; }

    }
}
