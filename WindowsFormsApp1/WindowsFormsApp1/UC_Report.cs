using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace WindowsFormsApp1
{
    public partial class UC_Report : UserControl
    {
        public const string REGIONS = "Regions";
        public const string INVESTIGATION_AREAS = "Investigation Areas";
        public const string CLASIFICATION = "Clasification";
        public const string CITIES = "Cities";

        private App program;
        GMapOverlay markers;


        public UC_Report(App program)
        {
            InitializeComponent();
            this.program = program;
            comboBox1.Items.Add(REGIONS);
            comboBox1.Items.Add(CITIES);
            comboBox1.Items.Add(INVESTIGATION_AREAS);
            comboBox1.Items.Add(CLASIFICATION);
            markers = new GMapOverlay("markers");
        }


        public UC_Report()
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            markers.Markers.Clear();
            String type = comboBox1.SelectedItem.ToString();

            if(type.Equals(REGIONS)){
                program.Report.getRegionsFilter().ToList().ForEach(n => comboBox2.Items.Add(n.Region));
            }
            else if(type.Equals(INVESTIGATION_AREAS)){
                program.Report.getInvestigationAreasFilter().ToList().ForEach(n => comboBox2.Items.Add(n.OcdeArea));
            }
            else if (type.Equals(CLASIFICATION)){
                program.Report.getClasificationFilter().ToList().ForEach(n => comboBox2.Items.Add(n.Clasification));
            }else if (type.Equals(CITIES))
            {
                program.Report.getCitiesFilter().ToList().ForEach(n => comboBox2.Items.Add(n.Municipality));
            }
            
           
        }

        private void UC_Report_Load(object sender, EventArgs e)
        {

        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter1 = comboBox1.SelectedItem.ToString();
            List<InvestigationGroup> ig_list = new List<InvestigationGroup>();

            string filter2 = comboBox2.SelectedItem.ToString();
            GMarkerGoogleType gmarker_type = new GMarkerGoogleType();



            switch (filter1)
            {
                
                case REGIONS:
                    gmarker_type = GMarkerGoogleType.blue_pushpin;
                    for (int i = 0; i < program.GroupList.Count(); i++)
                    {
                        if (program.GroupList.ElementAt(i).Region.Equals(filter2))
                        {
                            if (!ig_list.Contains(program.GroupList.ElementAt(i)))
                            {
                            ig_list.Add(program.GroupList.ElementAt(i));
                            }
                        }
                    }

                    break;
                case INVESTIGATION_AREAS:

                    gmarker_type = GMarkerGoogleType.green_pushpin;
                    for (int i = 0; i < program.GroupList.Count(); i++)
                    {
                        if (program.GroupList.ElementAt(i).OcdeArea.Equals(filter2))
                        {
                            ig_list.Add(program.GroupList.ElementAt(i));
                        }
                    }
                    break;
                case CLASIFICATION:
                    gmarker_type = GMarkerGoogleType.lightblue_pushpin;
                    for (int i = 0; i < program.GroupList.Count(); i++)
                    {
                        if (program.GroupList.ElementAt(i).Clasification.Equals(filter2))
                        {
                            ig_list.Add(program.GroupList.ElementAt(i));
                        }
                    }
                    break;
                case CITIES:
                    gmarker_type = GMarkerGoogleType.pink_pushpin;
                    for (int i = 0; i < program.GroupList.Count(); i++)
                    {
                        if (program.GroupList.ElementAt(i).Municipality.Equals(filter2))
                        {
                            ig_list.Add(program.GroupList.ElementAt(i));
                        }
                    }
                    break;
                default:
                    ig_list = program.GroupList.ToList();
                    break;
            }

            paintGMap_filter2(ig_list, gmarker_type);
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

            gMapControl1.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControl1.SetPositionByKeywords("Cali, Colombia.");
            gMapControl1.ShowCenter = false;
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(48.8617774, 2.349272), GMarkerGoogleType.red_pushpin);
            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);
        }


        public void paintGMap_filter2(List<InvestigationGroup> ig_list, GMarkerGoogleType gmarker_type)
        { 
            Random r = new Random();
            List<InvestigationGroup> ig_municipalities = new List<InvestigationGroup>();

            for (int i = 0; i < ig_list.Count(); i++)
            {
                Municipality s = program.Locat.MunicipalityList.Find(b => b.Name.Equals(ig_list.ElementAt(i).Municipality));

                if (s == null)
                {
                    MessageBox.Show(ig_list.ElementAt(i).Municipality);
                }else
                {

                double x = r.NextDouble() * (s.x1 - s.x2) + s.x2;
                double y = r.NextDouble() * (s.y1 - s.y2) + s.y2;



                GMapMarker marker = new GMarkerGoogle(new PointLatLng(y, x), gmarker_type);
                markers.Markers.Add(marker);

                }

            }
        }























    }
}
