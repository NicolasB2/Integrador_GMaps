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
            
            this.textBox1.Enabled = type;
            this.textBox2.Enabled = type;
            this.textBox3.Enabled = type;
            this.textBox4.Enabled = type;
            this.textBox5.Enabled = type;
            this.textBox6.Enabled = type;
            this.textBox7.Enabled = type;
            this.textBox8.Enabled = type;
            this.textBox9.Enabled = type;
            this.textBox10.Enabled = type;
            this.textBox11.Enabled = type;
            this.textBox12.Enabled = type;
            this.textBox13.Enabled = type;
            this.textBox14.Enabled = type;
            this.textBox15.Enabled = type;
            this.textBox16.Enabled = type;

        }

        public void datos(InvestigationGroup group)
        {
            this.textBox1.test =group.
            this.textBox2.Enabled = type;
            this.textBox3.Enabled = type;
            this.textBox4.Enabled = type;
            this.textBox5.Enabled = type;
            this.textBox6.Enabled = type;
            this.textBox7.Enabled = type;
            this.textBox8.Enabled = type;
            this.textBox9.Enabled = type;
            this.textBox10.Enabled = type;
            this.textBox11.Enabled = type;
            this.textBox12.Enabled = type;
            this.textBox13.Enabled = type;
            this.textBox14.Enabled = type;
            this.textBox15.Enabled = type;
            this.textBox16.Enabled = type;
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
