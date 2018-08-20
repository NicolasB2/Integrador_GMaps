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

        public Form1(String type)
        {
            InitializeComponent();
            Choose_Panel(type);
        }

        private void Choose_Panel(String type)
        {

            if (type.Equals(GROUP_INFO))
            {
                panel1.Show();
            }
            else if (type.Equals(REPORT))
            {
                panel2.Show();
            }
            else if (type.Equals(GROUP_LIST))
            {
                panel3.Show();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void uC_GroupList1_Load(object sender, EventArgs e)
        {

        }
    }
}
