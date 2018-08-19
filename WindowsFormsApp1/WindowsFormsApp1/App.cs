using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{



    class App
    {
        public List<InvestigationGroup> GroupList { set; get; }
        public Report Report { set; get; }
        public String file { set; get; }

        //This tells me if any of the groups on the list has been updated. 
        public bool ListUpdated { set; get; }


        public void RegisterGroup(string[] groupAttributes)
        {
            InvestigationGroup group = new InvestigationGroup(groupAttributes);
        }

        public void UpdateGroup(String selectedGroup, string[] groupAttributes)
        {

        }

        public InvestigationGroup GetGroupInfo(String nombre)
        {
              IEnumerable <InvestigationGroup> x =  from n in GroupList
                                                    where n.GroupNumber.Equals(nombre)
                                                    select n;

            return x.ElementAt(0);
        }

        public void getGroupsReport(string filter)
        {

        }

    }
}
