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
            //Form1 fSecond = new Form1(program);
            //fSecond.Choose_Panel(Form1.REPORT);
            //fSecond.Show();


            paintGMap_Reports();
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




            GMapMarker marker2 = new GMarkerGoogle(new PointLatLng(-76.6657526, 3.3950543), GMarkerGoogleType.red_pushpin);
           markers.Markers.Add(marker2);
            gMapControl1.Overlays.Add(markers);

            paintGMap_Reports();
 
        }


        public void paintGMap_Reports()
        {
            Random r = new Random();
            List<InvestigationGroup> ig_municipalities = new List<InvestigationGroup>();

            //string m_Name = UC_Report.comboBox2.SelectedItem.ToString();
            string m_Name = "Cali";

            for (int i = 0; i < program.GroupList.Count(); i++)
            {
                if (program.GroupList.ElementAt(i).Municipality.Equals(m_Name))
                {
                    ig_municipalities.Add(program.GroupList.ElementAt(i));
                }
            }

            Municipality m = program.Locat.MunicipalityList.Find(i => i.Name.Equals(m_Name));

            for (int i = 0; i < ig_municipalities.Count(); i++)
            {

                double x = r.NextDouble() * (m.x1 - m.x2) + m.x2;
                double y = r.NextDouble() * (m.y1 - m.y2) + m.y2;

                

            GMapMarker marker = new GMarkerGoogle(new PointLatLng(x,y), GMarkerGoogleType.red_pushpin);
               // MessageBox.Show(x + "   " + y);
                markers.Markers.Add(marker);
            }


            gMapControl1.Overlays.Add(markers);
            //MessageBox.Show(markers.Markers.Count()+ "");
        }
    }
}
