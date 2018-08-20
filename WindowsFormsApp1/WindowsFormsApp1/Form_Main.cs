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
    public partial class Form_Main : Form
    {
        private App program;
        private Form1 fSecond;

        public Form_Main()
        {
            this.program = new App();
            this.fSecond = new Form1(program);
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 fSecond = new Form1(this.program);
            fSecond.Choose_Panel(Form1.REPORT);
            fSecond.Show();
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
            Form1 fSecond = new Form1(this.program);
            fSecond.Choose_Panel(Form1.GROUP_LIST);
            fSecond.Show();
            fSecond.Edit_Info(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 fSecond = new Form1(this.program);
            fSecond.Choose_Panel(Form1.GROUP_INFO);
            fSecond.Show();
            fSecond.Edit_Info(true);
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
       
        }

        private void uC_GroupList1_Load(object sender, EventArgs e)
        {

        }
    }
}
