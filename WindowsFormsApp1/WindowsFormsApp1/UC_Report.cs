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
        public UC_Report(App program)
        {
            InitializeComponent();

            comboBox1.Items.Add("Regions");
            comboBox1.Items.Add("Cities");
            comboBox1.Items.Add("Investigation Areas");
            comboBox1.Items.Add("Clasification");
        }

        public UC_Report()
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.AddRange(null);
        }

        private void UC_Report_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
