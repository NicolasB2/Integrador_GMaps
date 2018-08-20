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

        public static List<Municipio> listadoMunicipios { get; set; }
        public static Dictionary<String, double[]> Coords { get; set; }


        public static double[] CalculatePoints(String place)
        {
            return Coords[place];
        }

        public static void generarLocaciones()
        {
            try
            {
                listadoMunicipios = new List<Municipio>
                StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\repos juanma\GMaps-.NET\WindowsFormsApp1\WindowsFormsApp1\Datos\ubicacionesMunicipios.txt");

                 String line = sr.ReadLine();

                while ((line = sr.ReadLine()) != null)
                {
                    String[] atributos = line.Split(';');

                    String nombre = atributos[0];
                    String cooY1 = atributos[1];
                    String cooX1 = atributos[2];
                    String cooY2 = atributos[3];
                    String cooX2 = atributos[4];

                    Municipio mun = new Municipio(nombre, cooY1, cooX1, cooY2, cooX2);

                    //añadir el elemento al arreglo correspondiente
                    listadoMunicipios.Add(mun);

                    line = sr.ReadLine();
                }

                sr.Close();
                //Console.ReadLine();
                //Thread.Sleep(4000);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
