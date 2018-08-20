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

        public Form1 form2; 
        
        public Form_Main()
        {
            InitializeComponent();
            //form2 = new Form1();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fSecond = new Form1(this.program);
            //fSecond.uC_GroupInfo1.type_TextBox(UC_GroupInfo.VISUALIZAR_INFO);
            fSecond.Choose_Panel(Form1.GROUP_LIST);
            fSecond.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fSecond = new Form1(this.program);
            //fSecond.uC_GroupInfo1.type_TextBox(UC_GroupInfo.ACTUALIZAR);
            fSecond.Choose_Panel(Form1.GROUP_LIST);
            fSecond.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 fSecond = new Form1(this.program);
            //fSecond.uC_GroupInfo1.type_TextBox(UC_GroupInfo.REGISTRAR);
            fSecond.Choose_Panel(Form1.GROUP_INFO);
            fSecond.Show();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.SetPositionByKeywords("Cali, Colombia");
            gMapControl1.ShowCenter = false;

            GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
            GMap.NET.WindowsForms.GMapMarker marker =
                new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                    new GMap.NET.PointLatLng(48.8617774, 2.349272),
                    GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_pushpin);

            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);
        }

        private void uC_GroupList1_Load(object sender, EventArgs e)
        {

        }
    }
}
