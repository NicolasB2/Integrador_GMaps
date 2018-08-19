using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Report
    {

        public static string REPORT_REGIONS = "REPORT_REGIONS";
        public static string REPORT_CITIES = "REPORT_CITIES";
        public static string REPORT_IAREAS = "REPORT_IAREAS";
        public static string REPORT_CLASIFICATION = "REPORT_CLASIFICATION";

        private App main;

        Report(App main )
        {
            this.main = main;
        }

        public IEnumerable<InvestigationGroup> getCitiesReport(String cities)
        {
            return  from n in main.GroupList
                    where n.Country.Equals(cities)
                    select n;
        }
        public IEnumerable<InvestigationGroup> getRegionsReport(String region)
        {
            return from n in main.GroupList
                   where n.Region.Equals(region)
                   select n;
        }
        public IEnumerable<InvestigationGroup> getInvestigationAreasReport(String area) 
        {
            return from n in main.GroupList
                   where n.OcdeArea.Equals(area)
                   select n;
        }
        public IEnumerable<InvestigationGroup> getClasificationReport(String clasification)
        {
            return from n in main.GroupList
                   where n.Clasification.Equals(clasification)
                   select n;
        } 
    }
}
