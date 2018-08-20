using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Municipality
    {
        public String Name { get; set; }
        public double y1 { get; set; }
        public double x1 { get; set; }
        public double y2 { get; set; }
        public double x2 { get; set; }

        public Municipality (String name, String cooY1, String cooX1, String cooY2, String cooX2)
        {
            Name = name;
            y1 = Double.Parse(cooY1);
            x1 = Double.Parse(cooX1);
            y2 = Double.Parse(cooY2);
            x2 = Double.Parse(cooX2);

        }


    }
}
