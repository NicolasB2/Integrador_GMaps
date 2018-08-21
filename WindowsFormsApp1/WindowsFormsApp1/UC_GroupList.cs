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
        private static Form1 second;

        public UC_GroupList(Form1 Second)
        {
            InitializeComponent();
            app = Second.program;
            second = Second;
            

            for (int i = 0; i < app.GroupList.Count(); i++)
            {
                listBox1.Items.Add(app.GroupList.ElementAt(i));
            }
        }

        public UC_GroupList()
        {
        }

        public string getSelectedItem()
        {
            string igName = "";

            try
            {
                igName = listBox1.SelectedItem.ToString();
            }
            catch (Exception e)
            {
                e.ToString();
                MessageBox.Show("You must select an Investigation Group to continue the process.");
            }
            return igName;
        }

        private void Investigation_groups_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            second.Send_data_UC_Info(app.GetGroup(listBox1.SelectedItem.ToString()));
            button2.Enabled = true;
        }

        private void UC_GroupList_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            second.Choose_Panel("GROUP_INFO");
        }
    }
}
