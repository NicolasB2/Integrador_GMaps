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
        public double[] Coord { get; set;  }

        public InvestigationGroup(String[] datos)
        {
            Announcement = datos[0];
            Year = int.Parse(datos[1]);
            Code = datos[2]; 
            Name = datos[3];
            CreationDate = datos[4];
            Municipality = datos[5];
            Department = datos[6];
            Country = datos[7];
            Region = datos[8];
            DaneID = datos[9];
            OcdeID = datos[10];
            OcdeArea = datos[11];
            OcdeLargeArea = datos[12];
            Clasification = datos[13];
            OrderClass = int.Parse( datos[14]);
            Age = int.Parse( datos[15]);
            Coord = generateCoordPoint(Municipality);
    }

        private double[] generateCoordPoint(String Country)
        { 
            return Location.CalculatePoints(Country);
        }
    }
}
