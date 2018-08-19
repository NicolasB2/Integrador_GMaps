using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class InvestigationGroup
    {

        public string Announcement { get; set; }
        public int Year { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string CreationDate { get; set; }
        public string Municipality { get; set; }
        public string Department { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string DaneID { get; set; }
        public string OcdeID { get; set; }
        public string OcdeArea { get; set; }
        public string OcdeLargeArea { get; set; }
        public string Clasification { get; set; }
        public int OrderClass { get; set; }
        public int Age { get; set; }
        public Point[] Coord { get; set;  }

        public InvestigationGroup(String[] datos)
        {
            generateCoordPoint(datos[0]);
        }

        private void generateCoordPoint(String Country)
        {
            Coord = Location.CalculatePoints(Country);
        }
    }
}
