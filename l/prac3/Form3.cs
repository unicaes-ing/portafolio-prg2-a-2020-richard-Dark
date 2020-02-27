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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnlanzar_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            const int CANTIDAD = 5000;
            int num = 0, cont = 0;
            lstLanza.Items.Clear();
            while (cont<CANTIDAD)
            {
                num = r.Next(1, 7);
                
                    lstLanza.Items.Add(num);
                    cont++;
             
            }
            if (true)
            {

            }
        }
    }
}
