using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UC_Report : UserControl
    {

        private App programe;
        public UC_Report(App programe)
        {
            InitializeComponent();
            this.programe = programe;
            comboBox1.Items.Add("Regions");
            comboBox1.Items.Add("Cities");
            comboBox1.Items.Add("Investigation Areas");
            comboBox1.Items.Add("Clasification");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            String type = comboBox1.SelectedItem.ToString();

            if(type.Equals("Regions")){
                programe.Report.getRegionsFilter().ToList().ForEach(n => comboBox2.Items.Add(n.Region));
            }
            else if(type.Equals("Investigation Areas")){
                programe.Report.getInvestigationAreasFilter().ToList().ForEach(n => comboBox2.Items.Add(n.OcdeArea));
            }
            else if (type.Equals("Clasification")){
                programe.Report.getClasificationFilter().ToList().ForEach(n => comboBox2.Items.Add(n.Clasification));
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
    }
}
