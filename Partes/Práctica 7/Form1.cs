using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Práctica_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool valido = true;
            errorProvider1.Clear();
            if (txtNombre.TextLength <= 0)
            {
                errorProvider1.SetError(txtNombre, "Ingrese su Nombre, no puede dejarlo en blanco");
                valido = false;
            }
            else
            {
                string patronNombre = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{1,})(\s)?)*[^\s]$";
                if (!Regex.IsMatch(txtNombre.Text,patronNombre))
                {
                    errorProvider1.SetError(txtNombre,"Ingrese correctamente su nombre\n(con inicial mayúscula en nombres y apellidos");
                    valido = false;
                }
            }
            if (!mtxTeléfono.MaskFull)
            {
                errorProvider1.SetError(mtxTeléfono, "Ingrese el teléfono completo");
                valido = false;
            }
            else
            {
                string patrontelefono = "^([2|6|7][0-9]{3})-([0-9]{4})$";
                if (!Regex.IsMatch(mtxTeléfono.Text, patrontelefono))
                {
                    errorProvider1.SetError(mtxTeléfono, "Ingrese un número válido");
                    valido = false;
                }

            }
            if (txtCorreo.TextLength <= 0)
            {
                errorProvider1.SetError(txtCorreo, "Ingrese su Correo, no puede dejar este campo en blanco");
                valido = false;
            }
            else
            {
                string patronCorreo = @"^\S[_a-zA-Z0-9-]+(.[_a-zA-Z0-9-]+)@\S[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{1,4})\S$"; ;
                if (!Regex.IsMatch(txtCorreo.Text, patronCorreo))
                {
                    errorProvider1.SetError(txtCorreo, "Ingrese correctamente el correo electronico\n(Debe llevar obligatoriamente el @, no debe de tener más de 1 punto ni debe de llevar espacios");
                    valido = false;
                }
                else if (txtCorreo.Text.Contains(";") || txtCorreo.Text.Contains(":"))
                {
                    errorProvider1.SetError(txtCorreo, "Algunos caracteres ingresados no son válidos");
                    valido = false;
                }
            }
            if (valido)
            {
                errorProvider1.Clear();
                FileStream fs = null;
                BinaryWriter bw = null;
                try
                {
                    fs = new FileStream("propietarios.dat", FileMode.Append, FileAccess.Write);
                    bw = new BinaryWriter(fs);
                    bw.Write(txtNombre.Text);
                    bw.Write(txtCorreo.Text);
                    bw.Write(mtxTeléfono.Text);
                    MessageBox.Show("Los datos ingresados Son válidos");
                    dataGridView1.Rows.Add(txtNombre.Text, txtCorreo.Text, mtxTeléfono.Text);
                    txtCorreo.Clear();
                    txtNombre.Clear();
                    mtxTeléfono.Clear();
                    txtNombre.Focus();

                }
                catch (Exception)
                {

                    MessageBox.Show("Ingrese los datos correctamente");
                }
                finally
                {
                    if (bw != null) bw.Close();
                }
            }



        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string nombre, correo, telefono;
            FileStream fs = null;
            BinaryReader br = null;
            try
            {
                fs = new FileStream("propietarios.dat", FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                dataGridView1.Rows.Clear();
                while (true)
                {
                    nombre = br.ReadString();
                    correo = br.ReadString();
                    telefono = br.ReadString();
                    dataGridView1.Rows.Add(nombre, correo, telefono);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                if (br != null) br.Close();
                dataGridView1.ClearSelection();
            }
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe agregar por lo menos un propietario.");
                txtNombre.Focus();
            }
        }
    }
}
