using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    public class Location
    {
        public List<InvestigationGroup> GroupList { set; get; }

        public static List<municipality> municipalityList { get; set; }


        public static void generarLocaciones()
        {
           // try
            //{
                //listadoMunicipios = new List<Municipio>
                //StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\repos juanma\GMaps-.NET\WindowsFormsApp1\WindowsFormsApp1\Datos\Municipios.xlsx");

                 //String line = sr.ReadLine();

               // while ((line = sr.ReadLine()) != null)
            //    {
            //        String[] atributos = line.Split(';');

            //        String nombre = atributos[0];
            //        String cooY1 = atributos[1];
            //        String cooX1 = atributos[2];
            //        String cooY2 = atributos[3];
            //        String cooX2 = atributos[4];

            //        municipality mun = new municipality(nombre, cooY1, cooX1, cooY2, cooX2);

            //        //Add element to the municipalityList
            //        municipalityList.Add(mun);

            //        line = sr.ReadLine();
            //    }

            //    sr.Close();
            //    //Console.ReadLine();
            //    //Thread.Sleep(4000);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Exception: " + e.Message);
            //}
        }
    }
}
