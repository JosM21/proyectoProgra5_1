﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoProgra5_1.Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void BtnVerContrasenia_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContrasenia.UseSystemPasswordChar= false;
        }

        private void BtnVerContrasenia_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContrasenia.UseSystemPasswordChar = true;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //validar usuario

            Globales.MiFormPrincipal.Show();
            this.Hide();
        }
    }
}
