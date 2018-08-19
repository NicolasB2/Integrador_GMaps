using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    class App
    {
        //ATTRIBUTES & CONSTANTS ****************************************************************

        //This tells me the relative path of file whit the infotmation of the groups
        public static String file = "";

        //Data Structure whit all the information of group list
        public List<InvestigationGroup> GroupList { set; get; }

        //This tells me if any of the groups on the list has been updated. 
        public Report Report { set; get; }

        //This tells me if any of the groups on the list has been updated. 
        public bool ListUpdated { set; get; }

        //CONSTRUCTOR
        public App()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Sara\Source\Repos\GMaps-.NET\WindowsFormsApp1\WindowsFormsApp1\Datos\datos.txt");
            while ((line = file.ReadLine()) != null )
            {
                if (!line.Trim().StartsWith("#"))
                {
                String[] info = line.Split(',');
                }
            }
        }

        //METHODS*******************************************************************************

        //this add the new investigation group in the file and GroupList
        public void RegisterGroup(string[] groupAttributes)
        {
            InvestigationGroup group = new InvestigationGroup(groupAttributes);
            GroupList.Add(group);
            ListUpdated = true;
        }

        //this method Update the data of the InvestigationGroup with the name entered by parameter
        public void UpdateGroup(String selectedGroup, string[] groupAttributes)
        {

        }

        //this method find and retorn the InvestigationGroup with the name of the parameter
        public InvestigationGroup GetGroup(String name)
        {
              IEnumerable <InvestigationGroup> x =  from n in GroupList
                                                    where n.Name.Equals(name)
                                                    select n;

            return x.ElementAt(0);
        }

        //
        public void getGroupsReport(string filter)
        {

        }

    }
}
