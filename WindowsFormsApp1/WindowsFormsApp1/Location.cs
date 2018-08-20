using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{


    public static class Location
    {


        public static Dictionary<String, double[]> Coords { get; set; }


        public static double[] CalculatePoints(String place)
        {
            return Coords[place];
        }
        
    }
}
