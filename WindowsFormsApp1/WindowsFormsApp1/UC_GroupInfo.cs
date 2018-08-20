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

        public UC_GroupInfo(App program)
        {
            InitializeComponent();
        }

        public void type_TextBox(string type)
        {
            bool x = false;
            if (type.Equals(ACTUALIZAR)||type.Equals(REGISTRAR))
            {
                x = true;
            }
            
            this.textBox1.Enabled = x;
            this.textBox2.Enabled = x;
            this.textBox3.Enabled = x;
            this.textBox4.Enabled = x;
            this.textBox5.Enabled = x;
            this.textBox6.Enabled = x;
            this.textBox7.Enabled = x;
            this.textBox8.Enabled = x;
            this.textBox9.Enabled = x;
            this.textBox10.Enabled = x;
            this.textBox11.Enabled = x;
            this.textBox12.Enabled = x;
            this.textBox13.Enabled = x;
            this.textBox14.Enabled = x;
            this.textBox15.Enabled = x;
            this.textBox16.Enabled = x;

        }


        private void UC_GroupInfo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
