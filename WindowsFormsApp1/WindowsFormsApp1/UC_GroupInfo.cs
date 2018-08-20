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
    public partial class UC_GroupInfo : UserControl
    {

        public bool type;
        public Form1 Second;

        public UC_GroupInfo(Form1 Second)
        {
            this.Second = Second;
            type = true;
            InitializeComponent();
        }

        public void Type_TextBox(bool type)
        {
            this.type = type;
            
            this.Announcement.Enabled = type;
            this.Year.Enabled = type;
            this.name.Enabled = type;
            this.Code.Enabled = type;
            this.Country.Enabled = type;
            this.Department.Enabled = type;
            this.Municipality.Enabled = type;
            this.CrreationDate.Enabled = type;
            this.Age.Enabled = type;
            this.OrderClass.Enabled = type;
            this.Clasification.Enabled = type;
            this.Ocde_Large.Enabled = type;
            this.Ocde_area.Enabled = type;
            this.Ocde_Id.Enabled = type;
            this.Dane_Id.Enabled = type;
            this.region.Enabled = type;

        }

        public void Data_Group(InvestigationGroup group)
        {
            Second.Delete_Group(group);
            this.Announcement.Text = group.Announcement;
            this.Year.Text = group.Year;
            this.name.Text = group.Name;
            this.Code.Text = group.Code;
            this.Country.Text = group.Country;
            this.Department.Text = group.Department;
            this.Municipality.Text = group.Municipality;
            this.CrreationDate.Text = group.CreationDate;
            this.Age.Text = group.Age+"";
            this.OrderClass.Text = group.OrderClass+"";
            this.Clasification.Text = group.Clasification;
            this.Ocde_Large.Text = group.OcdeLargeArea;
            this.Ocde_area.Text = group.OcdeArea;
            this.Ocde_Id.Text = group.OcdeID;
            this.Dane_Id.Text = group.DaneID;
            this.region.Text = group.Region;
        }
        private void UC_GroupInfo_Load(object sender, EventArgs e)
        {

        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (type)
            { 
                String[] data = new String[16];
                data[0] = this.Announcement.Text;
                data[1] = this.Year.Text;
                data[2] = this.name.Text;
                data[3] = this.Code.Text;
                data[4] = this.Country.Text;
                data[5] = this.Department.Text;
                data[6] = this.Municipality.Text;
                data[7] = this.CrreationDate.Text;
                data[8] = this.Age.Text;
                data[9] = this.OrderClass.Text;
                data[10] = this.Clasification.Text;
                data[11] = this.Ocde_Large.Text;
                data[12] = this.Ocde_area.Text;
                data[13] = this.Ocde_Id.Text;
                data[14] = this.Dane_Id.Text;
                data[15] = this.region.Text;


                Second.UpDate_InvestigationGroup(data);
            }

            Second.Close();
        }
    }
}
