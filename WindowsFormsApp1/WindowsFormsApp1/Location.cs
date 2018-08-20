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
        }

        public double[] CalculatePoints(String place)
        {
            try
            {
                return Coords[place];
            }
            catch
            {
                return null;
            }
        }
        
    }
}
