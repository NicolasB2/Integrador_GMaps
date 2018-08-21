using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public class App
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

        public Location Locat{set; get;}

        //CONSTRUCTOR
        public App()
        {
            GroupList = new List<InvestigationGroup>();
            Report = new Report(this);
            Locat = new Location();

            GroupList.Clear();
            inicilizarDataBase();
        }

        public void inicilizarDataBase()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader
             (@"C:\Users\Nicolas\Source\Repos\GMaps-.NET\WindowsFormsApp1\WindowsFormsApp1\Datos\datos.txt");

         
            int c = 0; 
            while ((line = file.ReadLine()) != null )
            {
                c++;
                String[] info = line.Split(';');

                try
                {
                InvestigationGroup ig = new InvestigationGroup(info);
                    GroupList.Add(ig);

                }catch(Exception e){
                    e.ToString();
                 //MessageBox.Show("Error en la fila: " + c );
                }

            }

            file.Close();
        }

        //METHODS*******************************************************************************

        //this add the new investigation group in the file and GroupList
        public void RegisterGroup(string[] groupAttributes)
        {
            InvestigationGroup group = new InvestigationGroup(groupAttributes);
            GroupList.Add(group);
            ListUpdated = true;
        }

        public void DeleteInvestigationGroup(InvestigationGroup delete)
        {
            GroupList.Remove(delete);
            
        }

        public void UpData_DataBase()
        {
            string ruta = @"C:\Users\Nicolas\Source\Repos\GMaps-.NET\WindowsFormsApp1\WindowsFormsApp1\Datos\datos.txt";
            
            System.IO.File.WriteAllText(ruta,String.Empty);

            System.IO.StreamWriter file = new System.IO.StreamWriter(ruta);
            GroupList.ForEach(n=>file.WriteLine(n.All_Data()));
            file.Close();
        }

        //this method find and return the InvestigationGroup with the name of the parameter
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
