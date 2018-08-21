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
        public App program;

        public Form1(App program)
        {
            this.program = program;
            InitializeComponent(program);
        }

        public void Choose_Panel(String type)
        {

            if (type.Equals(GROUP_INFO))
            {
                uC_GroupInfo1.Show();
                uC_Report1.Hide();
                uC_GroupList1.Hide();
            }
            else if (type.Equals(REPORT))
            {
                uC_Report1.Show();
                uC_GroupList1.Hide();
                uC_GroupInfo1.Hide();

            }
            else if (type.Equals(GROUP_LIST))
            {
                uC_GroupList1.Show();
                uC_GroupInfo1.Hide();
                uC_Report1.Hide();
            }
            
        }

        public void Send_data_UC_Info(InvestigationGroup group)
        {
            uC_GroupInfo1.Data_Group(group);
        }

        internal void Delete_Group(InvestigationGroup group)
        {
            program.DeleteInvestigationGroup(group);
        }

        public void Edit_Info(bool type)
        {
            uC_GroupInfo1.Type_TextBox(type);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        internal void UpDate_InvestigationGroup(String[] group)
        {
            this.program.RegisterGroup(group);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
