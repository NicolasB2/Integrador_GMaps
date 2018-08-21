using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class Form_Main : Form
    {
        private App program;
        private Form1 fSecond;
        GMapOverlay markers;
       

        public Form_Main()
        {
            program = new App();
            fSecond = new Form1(program);
            markers = new GMapOverlay("markers");
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 fSecond = new Form1(program);
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
            Form1 fSecond = new Form1(program);
            fSecond.Choose_Panel(Form1.GROUP_LIST);
            fSecond.Show();
            fSecond.Edit_Info(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 fSecond = new Form1(program);
            fSecond.Choose_Panel(Form1.GROUP_INFO);
            fSecond.Show();
            fSecond.Edit_Info(true);

        }


        private void uC_GroupList1_Load(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {           
            gMapControl1.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControl1.SetPositionByKeywords("Cali, Colombia.");
            gMapControl1.ShowCenter = false;

            Random r = new Random();
            for (int i = 0; i < program.GroupList.Count; i++)
            {
                Municipality s = program.Locat.MunicipalityList.Find(b => b.Name.Equals(program.GroupList.ElementAt(i).Municipality));

                if (s == null)
                {
                   // MessageBox.Show(program.GroupList.ElementAt(i).Municipality);
                }

                if (s != null)
                {

                double x = r.NextDouble() * (s.x1 - s.x2) + s.x2;
                double y = r.NextDouble() * (s.y1 - s.y2) + s.y2;

                    //if (program.GroupList.ElementAt(i).Region.Equals("Centro Oriente"))
                   // {
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(y, x), GMarkerGoogleType.red_pushpin);
                markers.Markers.Add(marker);

                    //}
                }
            }

            gMapControl1.Overlays.Add(markers);
 
        }
    }
}
