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
        public string announcement { get; set; }
        public int year { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string creationDate { get; set; }
        public string municipality { get; set; }
        public string department { get; set; }
        public string country { get; set; }
        public string region { get; set; }
        public string daneID { get; set; }
        public string ocdeID { get; set; }
        public string ocdeArea { get; set; }
        public string ocdeLargeArea { get; set; }
        public string classification { get; set; }
        public int orderClass { get; set; }
        public int age { get; set; }

        public Point coord { get; set;  }
    }
}
