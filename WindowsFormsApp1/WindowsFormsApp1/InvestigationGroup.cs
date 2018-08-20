using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    public class InvestigationGroup
    {

        private Location points;

        public string Announcement { get; set; }
        public string Year { get; set; }
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

        public InvestigationGroup(String[] info)
        {
            points = new Location();
            Announcement = info[0];
            Year = info[1];
            Code = info[2];
            Name = info[3];
            CreationDate = info[4];
            Municipality = info[5];
            Department = info[6];
            Country = info[7];
            Region = info[8];
            DaneID = info[9];
            OcdeID = info[10];
            OcdeArea = info[11];
            OcdeLargeArea = info[12];
            Clasification = info[13];
            OrderClass = int.Parse(info[14]);
            Age = int.Parse(info[15]);

            generateCoordPoint(Country);
        }


        public override string ToString()
        {
            return this.Name;
        }

        private double[] generateCoordPoint(String Country)
        {

            return null;
        }


    }
}
