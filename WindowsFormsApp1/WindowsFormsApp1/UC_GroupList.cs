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
    public partial class UC_GroupList : UserControl
    {
        private static App app;
        public UC_GroupList()
        {
            app = new App();
            InitializeComponent();

            app.GroupList.ForEach(listBox1.Items.Add(Name));

            


            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Sara\source\repos\ConsoleApp2\WindowsFormsApp3\Listados\listado.txt");
            while ((line = file.ReadLine()) != null)
            {
                listBox1.Items.Add(line);

            }


        }

        private void Investigation_groups_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
