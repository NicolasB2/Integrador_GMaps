using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{


    public class Location
    {


        public static Dictionary<String, double[]> Coords { get; set; }

        public Location()
        {
            Coords = new Dictionary<String, double[]>();
            double[] x = { 1.0, 2.88, 4.2, 3.2 };


        }
        public static double[] CalculatePoints(String place)
        {
            return Coords[place];
        }
        
    }
}
