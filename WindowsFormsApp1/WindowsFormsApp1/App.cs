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

        //This tells me if any of the groups on the list has been updated. 
        public bool ListUpdated { set; get; }


        public void RegisterGroup(string[] groupAttributes)
        {

        }

        public void UpdateGroup(string[] groupAttributes)
        {

        }

        public void GetGroupInfo(InvestigationGroup iG)
        {

        }

        public void getGroupsReport(string filter)
        {

        }

    }
}
