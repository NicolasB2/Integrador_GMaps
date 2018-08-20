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
        public static String VISUALIZAR_INFO = "VISUALIZAR_INFO";
        public static String ACTUALIZAR = "ACTUALIZAR";
        public static String REGISTRAR = "REGISTRAR";
        public bool type;
        public UC_GroupInfo()
        {
            type = true;
            InitializeComponent();
        }

        public void type_TextBox(bool type)
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
            this.Region.Enabled = type;

        }

        public void Data_Group(InvestigationGroup group)
        {
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
            this.Region.Text = group.Region;
        }
        private void UC_GroupInfo_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
