using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form3
{
    public partial class form3 : Form
    {
        public form3()
        {
            InitializeComponent();
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int c= 0;
            lstDado.Items.Clear();
            for (int i = 0; i <= 5000; i++)
            {
                int num = r.Next(1, 7);
                if (num == 6) c++;
            }
            MessageBox.Show("Se obtuvo " + c + " veces el 6");
        }

    }
}
