using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lstTabla.Items.Clear();
            int num;
            int respuesta;
            if (int.TryParse(txtLaTabla.Text, out num))
            {
                for (int i = 1; i <= 10; i++)
                {
                    respuesta = num * i;
                    lstTabla.Items.Add(num + "x" + i + "=" + respuesta);
                }
            }
            else
            {
                MessageBox.Show("ingrse un numero");
            }
        }
    }
}
