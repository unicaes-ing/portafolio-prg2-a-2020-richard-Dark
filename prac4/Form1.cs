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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int Suma(int n1, int n2, int n3,int n4)
        {
            return n1 + n2 + n3+n4; 
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txtN1.Text);
            int n2 = Convert.ToInt32(txtN2.Text);
            int n3 = Convert.ToInt32(txtN3.Text);
            int n4 = Convert.ToInt32(txtN4.Text);
            int sum = Suma(n1, n2, n3, n4);
            lblSuma.Text = Convert.ToString(sum);
        }

        
    }
}
