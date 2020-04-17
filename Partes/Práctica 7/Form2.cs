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
using System.Runtime.Serialization.Formatters.Binary;

namespace Práctica_7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        [Serializable]
        public struct Mascotas
        {
            public string Código;
            public string Nombre;
            public string Propietario;
            public string Especie;
            public string Fecha;
            public double Peso;
            public string Sexo;

        }
        Mascotas mascota = new Mascotas();
        Dictionary<string, Mascotas> DiccionarioMascotas = new Dictionary<string, Mascotas>();
        private static BinaryFormatter formatter = new BinaryFormatter();
        private const string NOMBRE_ARCHIVO = "mascotas.dat";

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarMascotas_Click(object sender, EventArgs e)
        {
            bool validado = true;
            err.Clear();
            if (txtNombre.TextLength <= 0)
            {
                err.SetError(txtNombre, "Ingrese su Nombre, no puede dejarlo en blanco");
                validado = false;
            }
            else
            {
                string patronnombre = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{2,})(\s)?)*[^\s]$";
                if (!Regex.IsMatch(txtNombre.Text, patronnombre))
                {

                    err.SetError(txtNombre, "Ingrese correctamente su nombre\n(con inicial mayúscula en nombres y apellidos)");
                    validado = false;
                }
            }
            if (Convert.ToString(cboPropietario.SelectedItem) == "")
            {
                err.SetError(cboPropietario, "El propietario es un campo obligatorio, eliga una opción");
                validado = false;
            }
            if (Convert.ToString(cboEspecie.SelectedItem) == "")
            {
                err.SetError(cboEspecie, "La especie es un campo obligatorio, eliga una opción");
                validado = false;
            }
            if (txtPeso.TextLength <= 0 || txtPeso.Text.StartsWith("."))
            {
                err.SetError(txtPeso, "Ingrese un peso válido");
                validado = false;
            }
            else if (txtPeso.Text.StartsWith("."))
            {
                err.SetError(txtPeso, "Solo debe de ingresar un punto");
                validado = false;
            }
            if (!mtxCódigoDeMascotas.MaskFull)
            {
                err.SetError(mtxCódigoDeMascotas, "No debe de dejar el espacio en blanco");
                validado = false;
            }
            
            if (validado)
            {
               
                mascota.Código = mtxCódigoDeMascotas.Text;
                mascota.Nombre = txtNombre.Text;
                mascota.Propietario = cboPropietario.Text;
                mascota.Especie = cboEspecie.Text;
                mascota.Fecha = dateTimePicker1.Text;
                mascota.Peso = Convert.ToDouble(txtPeso.Text);
                mtxCódigoDeMascotas.Clear();
                txtNombre.Clear();
                cboPropietario.SelectedIndex = -1;
                cboEspecie.SelectedIndex = -1;
                txtPeso.Clear();
                rdoMacho.Checked = true;
                err.Clear();
                mtxCódigoDeMascotas.Focus();
                if (rdoHembra.Checked)
                {
                    mascota.Sexo = Convert.ToString(rdoHembra.Text);
                }
                else
                {
                    mascota.Sexo = Convert.ToString(rdoMacho.Text);
                }
                if (DiccionarioMascotas.ContainsKey(mtxCódigoDeMascotas.Text))
                {
                    MessageBox.Show("El código ya existe");
                }
                else
                {
                    DiccionarioMascotas.Add(mtxCódigoDeMascotas.Text,mascota);
                    dataGridView1.Rows.Add(mascota.Código, mascota.Nombre, mascota.Propietario, mascota.Especie, mascota.Fecha, mascota.Peso,mascota.Sexo);
                    try
                    {
                        FileStream writerFS = new FileStream(NOMBRE_ARCHIVO, FileMode.Create, FileAccess.Write);
                        formatter.Serialize(writerFS,DiccionarioMascotas);
                        writerFS.Close();
                        MessageBox.Show("Los datos han sido ingresados correctamente");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No fue posible almacenar los datos de empleados");
                    }
                }


               
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string Nombre, Correo, Telefono;
            FileStream fs = null;
            BinaryReader br = null;
            try
            {
                fs = new FileStream("propietarios.dat", FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                cboPropietario.Items.Clear();
                while (true)
                {
                    Nombre = br.ReadString();
                    Correo = br.ReadString();
                    Telefono = br.ReadString();
                    cboPropietario.Items.Add(Nombre);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                if (br != null)
                {
                    br.Close();
                }
            }
            if (File.Exists(NOMBRE_ARCHIVO))
            {
              try
              {
                  FileStream ReaderFS = new FileStream(NOMBRE_ARCHIVO, FileMode.Open, FileAccess.Read);
                  DiccionarioMascotas = (Dictionary<string, Mascotas>)formatter.Deserialize(ReaderFS);
                  ReaderFS.Close();

              }
              catch (Exception)
              {
              }
            }
            else
            {
                MessageBox.Show("El archivo no existe");
            }
            if (DiccionarioMascotas.Count > 0)
            {
                dataGridView1.Rows.Clear();
                foreach (Mascotas mascota in DiccionarioMascotas.Values)
                {
                    dataGridView1.Rows.Add(mascota.Código, mascota.Nombre, mascota.Propietario, mascota.Especie, mascota.Fecha, mascota.Peso, mascota.Sexo);
                }
                dataGridView1.ClearSelection();
            }
        }
    }
}

