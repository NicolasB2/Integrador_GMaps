using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_Main : Form
    {
        private App program;
        private Form1 fSecond;

        public Form_Main()
        {
            this.program = new App();
            this.fSecond = new Form1(program);
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 fSecond = new Form1(this.program);
            fSecond.Choose_Panel(Form1.REPORT);
            fSecond.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fSecond = new Form1(this.program);
            fSecond.Choose_Panel(Form1.GROUP_LIST);
            fSecond.Show();
            fSecond.Edit_Info(false);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fSecond = new Form1(this.program);
            fSecond.Choose_Panel(Form1.GROUP_LIST);
            fSecond.Show();
            fSecond.Edit_Info(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 fSecond = new Form1(this.program);
            fSecond.Choose_Panel(Form1.GROUP_INFO);
            fSecond.Show();
            fSecond.Edit_Info(true);
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
           /* gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.SetPositionByKeywords("Cali, Colombia");
            gMapControl1.ShowCenter = false;*/

           // GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");

           /* GMap.NET.WindowsForms.GMapMarker marker =
                new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                    new GMap.NET.PointLatLng(48.8617774, 2.349272),
                    GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_pushpin);*/

            int cantidadCI = program.GroupList.Count(n => n.Municipality.Equals(UC_Report.comboBox2.SelectedItem.ToString()));

            Municipio municipio = Location.listadoMunicipios.FirstOrDefault(x => x.Name.equals(UC_Report.comboBox2.SelectedItem.ToString());

            Random random = new Random();
          

            for (int i = 0; i < cantidadCI; i++)
            {
               
                double x = random.NextDouble() * (municipio.x1 - municipio.x2) + municipio.x2;
                double y = random.NextDouble() * (municipio.y1 - municipio.y2) + municipio.y2;

                 GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");

            GMap.NET.WindowsForms.GMapMarker marker =
                new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                    new GMap.NET.PointLatLng(x, y),
                    GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_pushpin);

                markers.Markers.Add(marker);
                gMapControl1.Overlays.Add(markers);
            }

           /* markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);*/
        }

        private void uC_GroupList1_Load(object sender, EventArgs e)
        {

        }
    }
}
