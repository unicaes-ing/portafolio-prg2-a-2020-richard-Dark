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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtN.Text);
                string romano = "";
                if (num == 1)
                {
                    romano = "I";
                }
                else if (num == 2)
                {
                    romano = "II";
                }
                else if (num == 3)
                {
                    romano = "III";
                }
                else if (num == 4)
                {
                    romano = "IV";
                }
                else if (num == 5)
                {
                    romano = "V";
                }
                else if (num == 6)
                {
                    romano = "VI";
                }
                else if (num == 7)
                {
                    romano = "VII";
                }
                else if (num == 8)
                {
                    romano = "VIII";
                }
                else if (num == 9)
                {
                    romano = "IX";
                }
                else if (num == 10)
                {
                    romano = "X";
                }
                label2.Text = "equivale a " + romano + "  en romano";
            }

            catch (Exception )
            {
                MessageBox.Show("por favor ingrse un número de 1 al 10");
                txtN.SelectAll();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
