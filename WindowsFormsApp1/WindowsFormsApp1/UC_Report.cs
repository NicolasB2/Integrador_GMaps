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

        private App programe;
        GMapOverlay markers;


        public UC_Report(App programe)
        {
            InitializeComponent();
            this.programe = programe;
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
            String type = comboBox1.SelectedItem.ToString();

            if(type.Equals(REGIONS)){
                programe.Report.getRegionsFilter().ToList().ForEach(n => comboBox2.Items.Add(n.Region));
            }
            else if(type.Equals(INVESTIGATION_AREAS)){
                programe.Report.getInvestigationAreasFilter().ToList().ForEach(n => comboBox2.Items.Add(n.OcdeArea));
            }
            else if (type.Equals(CLASIFICATION)){
                programe.Report.getClasificationFilter().ToList().ForEach(n => comboBox2.Items.Add(n.Clasification));
            }else if (type.Equals(CITIES))
            {
                programe.Report.getCitiesFilter().ToList().ForEach(n => comboBox2.Items.Add(n.Municipality));
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
    }
}
