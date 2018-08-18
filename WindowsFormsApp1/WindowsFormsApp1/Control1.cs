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
    public partial class Control1 : UserControl
    {
        public Control1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            String filtro1 = comboBox_atributos.SelectedText;

            comboBox_2doFiltro.Items.Clear();

            if (filtro1.Equals("Grupos"))
            {
                comboBox_2doFiltro.Items.AddRange();
            }
            else if (filtro1.Equals("Municipio"))
            {

            }else if (filtro1.Equals("Departamento"))
            {

            }else if (filtro1.Equals("Región"))
            {

            }else if (filtro1.Equals("Área"))
            {

            }else if (filtro1.Equals("Área mayor"))
            {

            }
            else
            {

            }

           
        }
    }
}
