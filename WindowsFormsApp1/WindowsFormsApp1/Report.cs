using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Compared_Region : IEqualityComparer<InvestigationGroup>
    {
        public bool Equals(InvestigationGroup x, InvestigationGroup y)
        {
            return x.Region.Equals(y.Region);
        }

        public int GetHashCode(InvestigationGroup obj)
        {
            return obj.GetHashCode();
        }
    }

    class Compared_Area : IEqualityComparer<InvestigationGroup>
    {
        public bool Equals(InvestigationGroup x, InvestigationGroup y)
        {
            return x.OcdeArea.Equals(y.OcdeArea);
        }

        public int GetHashCode(InvestigationGroup obj)
        {
            return obj.GetHashCode();
        }
    }

    class Compared_Clasification : IEqualityComparer<InvestigationGroup>
    {
        public bool Equals(InvestigationGroup x, InvestigationGroup y)
        {
            return x.Clasification.Equals(y.Clasification);
        }

        public int GetHashCode(InvestigationGroup obj)
        {
            return obj.GetHashCode();
        }
    }

    public class Report
    {

        private App main;

        public Report(App main )
        {
            this.main = main;
        }

        //METHODS*******************************************************************************

        //The following methods generate an IEnumerable with the elements needed to apply the second filter
        public IEnumerable<InvestigationGroup> getCitiesFilter()
        {
            return main.GroupList.Distinct();
        }
        public IEnumerable<InvestigationGroup> getRegionsFilter()
        {
            return main.GroupList.Distinct(new Compared_Region());
        }
        public IEnumerable<InvestigationGroup> getInvestigationAreasFilter()
        {
            return main.GroupList.Distinct(new Compared_Area());
        }
        public IEnumerable<InvestigationGroup> getClasificationFilter()
        {
            return main.GroupList.Distinct(new Compared_Clasification());
        }


        //The following methods generate an IEnumerable with all the InvestigationGroup that fulfilled the two filters
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
