using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtAgregar.Text);
                lstAgregado.Items.Add(txtAgregar.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("ingrese un nuemero");
            }
            
        }
        public static int BuscarNumer(int numeroBuscar,ListBox lista)
        {
            int cont = 0;
            foreach (var numero in lista.Items)
            {
                if (Convert.ToInt32(numero) == numeroBuscar) cont++;
            }
            return cont;
              
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int nm = Convert.ToInt32(txtBuscar.Text);
            int c = BuscarNumer(nm, lstAgregado);
            MessageBox.Show("se encuentra" + c + "veces");
        }
    }
}
