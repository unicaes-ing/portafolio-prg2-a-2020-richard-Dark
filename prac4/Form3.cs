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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private static int FuncionFibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return FuncionFibonacci(n - 1) + FuncionFibonacci(n - 2);

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text);
            int fibo = FuncionFibonacci(num);
            txtFibo.Text = string.Format("{0}", fibo);
        }
    }
}
