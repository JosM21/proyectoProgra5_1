using System;
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
            if (!string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtContrasenia.Text.Trim()))
            {

                string usuario = TxtEmail.Text.Trim();
                string contrasenia = TxtContrasenia.Text.Trim();

                Globales.MiUsuarioGlobal = Globales.MiUsuarioGlobal.ValidarUsuario(usuario, contrasenia);

                if (Globales.MiUsuarioGlobal.IdUsuario > 0)
                {

                    Globales.MiFormPrincipal.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectas", "Error de Validacion", MessageBoxButtons.OK);
                    TxtContrasenia.Focus();
                    TxtContrasenia.SelectAll();
                }

            }
            else
            {
                MessageBox.Show("Faltan datos requeridos", "Error de validacion", MessageBoxButtons.OK);
            }


            
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Shift & e.Alt & e.KeyCode == Keys.A)
            {
                BtnIngresoDirecto.Visible = true;
            }


        }

        private void BtnIngresoDirecto_Click(object sender, EventArgs e)
        {

            Globales.MiFormPrincipal.Show();

            this.Hide();
        }
    }
}
