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
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void FrmMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (!Globales.MiFormGestionUsuario.Visible)
            {

                Globales.MiFormGestionUsuario = new FrmUsuarioGestion();
                Globales.MiFormGestionUsuario.Show();
            }
        }

        private void agentesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Globales.MiFormGestionAgente.Visible)
            {

                Globales.MiFormGestionAgente = new FrmAgenteGestion();
                Globales.MiFormGestionAgente.Show();
            }

        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Globales.MiFormSucursalGestion1.Visible)
            {

                Globales.MiFormSucursalGestion1 = new FrmSucursalGestion1();
                Globales.MiFormSucursalGestion1.Show();
            }

        }

        private void inmuebleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Globales.MiFormGestionInmueble.Visible)
            {

                Globales.MiFormGestionInmueble = new FrmInmuebleGestion();
                Globales.MiFormGestionInmueble.Show();
            }
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormGestionCita.Visible)
            {

                Globales.MiFormGestionCita = new FrmCitaGestion();
                Globales.MiFormGestionCita.Show();
            }

        }

        private void cliente1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Globales.MiFormGestionCLiente1.Visible)
            {

                Globales.MiFormGestionCLiente1 = new FrmClienteGestion1();
                Globales.MiFormGestionCLiente1.Show();
            }


        }

        private void FrmMDI_Load(object sender, EventArgs e)
        {

            string InfoUsuario = string.Format("{0}-{1} ({2})", Globales.MiUsuarioGlobal.Nombre,
                                                                Globales.MiUsuarioGlobal.Email,
                                                                Globales.MiUsuarioGlobal.FkIdUsuarioRol.Descripcion);
            LblUsuario.Text = InfoUsuario;



            LblUsuario.Text = InfoUsuario;

            switch (Globales.MiUsuarioGlobal.FkIdUsuarioRol.IdUsuarioRol)
            {
                case 1:
                    break;
                case 2:
                    usuariosToolStripMenuItem.Visible = false;
                    sucursalToolStripMenuItem.Visible = false;

                    break;
            }
        }


    }
}
