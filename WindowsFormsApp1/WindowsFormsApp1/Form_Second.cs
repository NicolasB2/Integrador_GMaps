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
    public partial class Form1 : Form
    {

        public static String GROUP_INFO = "GROUP_INFO";
        public static String REPORT = "REPORT";
        public static String GROUP_LIST = "GROUP_LIST";

        private UC_GroupInfo uC_GroupInfo1;
        private UC_Report uC_Report1;
        private UC_GroupList uC_GroupList1;

        public Form1(App program)
        {
            uC_GroupInfo1 = new UC_GroupInfo();
            uC_Report1 = new UC_Report();
            uC_GroupList1 = new UC_GroupList();


            InitializeComponent(program);
        }

        public void Choose_Panel(String type)
        {

            if (type.Equals(GROUP_INFO))
            {
                this.uC_GroupInfo1.Show();
                this.uC_Report1.Hide();
                this.uC_GroupList1.Hide();
            }
            else if (type.Equals(REPORT))
            {
                this.uC_Report1.Show();
                this.uC_GroupList1.Hide();
                this.uC_GroupInfo1.Hide();
            }
            else if (type.Equals(GROUP_LIST))
            {
                this.uC_GroupList1.Show();
                this.uC_GroupInfo1.Hide();
                this.uC_Report1.Hide();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
