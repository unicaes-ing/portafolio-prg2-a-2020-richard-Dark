using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double cant = Convert.ToDouble(txtCantidad.Text), precio = Convert.ToDouble(txtPrecio.Text), desc, descuento, total;
            try
            {
              
                if (rdoDesc1.Checked)
                {
                    txtdescuento.Text = "0.00";
                    total = cant * precio;
                    txtTotal.Text =Convert.ToString( total);

                }
                else if (rdoDesc2.Checked)
                {
                    total = cant * precio;
                    desc = precio * 0.05;
                    descuento = desc * cant;
                    txtdescuento.Text =Convert.ToString( descuento);
                    txtTotal.Text = Convert.ToString(total);
                }
                else if (rdoDesc3.Checked)
                {
                    total = cant * precio;
                    desc = precio * 0.10;
                    descuento = desc * cant;
                    txtdescuento.Text = Convert.ToString(descuento);
                    txtTotal.Text = Convert.ToString(total);
                }
                else if (rdoDesc4.Checked)
                {
                    total = cant * precio;
                    desc = precio * 0.15;
                    descuento = desc * cant;
                    txtdescuento.Text = Convert.ToString(descuento);
                    txtTotal.Text = Convert.ToString(total);
                }
                else if (rdoDesc5.Checked)
                {
                    total = cant * precio;
                    desc = precio * 0.10;
                    descuento = desc * cant;
                    txtdescuento.Text = Convert.ToString(descuento);
                    txtTotal.Text = Convert.ToString(total);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("revise el formulario");
            }
            

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtdescuento.Clear();
            txtPrecio.Clear();
            txtTotal.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
