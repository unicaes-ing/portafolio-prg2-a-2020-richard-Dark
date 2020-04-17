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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
           
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double de = Convert.ToDouble(txtLongaConvert.Text), convert;
            if (listBox1.SelectedItem.Equals("Pulgadas"))
            {
                if (listBox2.SelectedItem.Equals("Pulgadas"))
                {
                    txtLongConvert.Text = txtLongaConvert.Text;

                }
                else if (listBox2.SelectedItem.Equals("Pies"))
                {
                    convert = de / 12;

                    txtLongConvert.Text = Convert.ToString(convert);
                }
                else if (listBox2.SelectedItem.Equals("Yardas"))
                {
                    convert = de / 36;
                    txtLongConvert.Text = Convert.ToString(convert);
                }
                else
                {
                    MessageBox.Show("escoga una opción por favor");
                }
                
            }
            else if (listBox1.SelectedItem.Equals("Pies"))
            {
                if (listBox2.SelectedItem.Equals("Pulgadas"))
                {
                    convert = de * 12;
                    txtLongConvert.Text = Convert.ToString(convert);
                }
            
                else if (listBox2.SelectedItem.Equals("Pies"))
                {
                    txtLongConvert.Text = txtLongaConvert.Text;

                }
                else if (listBox2.SelectedItem.Equals("Yardas"))
                {
                    convert = de / 3;
                    txtLongConvert.Text = Convert.ToString(convert);
                }
                else
                {
                    MessageBox.Show("escoga una opción por favor");
                }
            }
            else if (listBox1.SelectedItem.Equals("Yardas"))
            {
                if (listBox2.SelectedItem.Equals("Pulgadas"))
                {
                    convert = de * 36;
                    txtLongConvert.Text = Convert.ToString(convert);
                }

                else if (listBox2.SelectedItem.Equals("Pies"))
                {
                    convert = de * 3;
                    txtLongConvert.Text = Convert.ToString(convert);

                }
                else if (listBox2.SelectedItem.Equals("Yardas"))
                {
                    txtLongConvert.Text = txtLongaConvert.Text;
                }
                else
                {
                    MessageBox.Show("escoga una opción por favor");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
