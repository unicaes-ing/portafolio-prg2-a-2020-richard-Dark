﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Practica_2
{
    public partial class form4 : Form
    {
        public form4()
        {
            InitializeComponent();
        }

        private void txtCorreo_Validating(object sender, EventArgs e)
        {
            string correo = @"^\S[_a-zA-Z0-9-]+(.[_a-zA-Z0-9-]+)*@\S[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})\S$";
            if (Regex.IsMatch(txtCorreo.Text, correo) == false)
            {
              
                txtCorreo.SelectAll();
                errorProvider1.SetError(txtCorreo, "Error\nel correo ingresado no es valido");
            }
      
        }
        private void txtCorreo_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        private void txtContra_Validating(object sender, CancelEventArgs e)
        {
            string contra = @"(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$";
            if (txtContra.TextLength < 8)
            {
                e.Cancel = true;
                txtContra.SelectAll();
                errorProvider1.SetError(txtContra, "la contraseña debe contener solo 8 caracteres...");
            }
            else if (!Regex.IsMatch(txtContra.Text, contra))
            {
                e.Cancel = true;
                txtContra.SelectAll();
                errorProvider1.SetError(txtContra, "la contraseña debe contener almenos:\nun numero, una letra mayuscula , una leta minuscula y un caracter especial...");
            }
        }

        private void txtContra_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtConfirmar_Validating(object sender, CancelEventArgs e)
        {
            string confirmacion = @"(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$";
            if (txtConfirmar.TextLength < 8)
            {
                e.Cancel = true;
                txtConfirmar.SelectAll();
                errorProvider1.SetError(txtConfirmar, "la contraseña debe contener solo 8 caracteres...");
            }
            else if (!Regex.IsMatch(txtConfirmar.Text, confirmacion))
            {
                e.Cancel = true;
                txtConfirmar.SelectAll();
                errorProvider1.SetError(txtConfirmar, "la contraseña debe contener almenos:\nun numero, una letra mayuscula , una leta minuscula y un caracter especial...");
            }
        }

        private void txtConfirmacionContra_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtContra.Text, txtConfirmar.Text))
            {
                MessageBox.Show("la confirrmacion de su contraseña no es igual a su contraseña...");
            }
            else if (txtCorreo.Text == "" && txtContra.Text == "" && txtConfirmar.Text == "")
            {
                MessageBox.Show("debe ingresar todos los datos ");
            }
            else
            {
                MessageBox.Show("los datos ingresados son validos\nlos datos han sido almacenados con exito.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
}
