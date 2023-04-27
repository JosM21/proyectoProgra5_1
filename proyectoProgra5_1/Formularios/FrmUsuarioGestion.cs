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
    public partial class FrmUsuarioGestion : Form
    {


        private Logica.Modelos.Usuario MiUsuarioLocal { get; set; }

        private DataTable ListarUsuario { get; set; }


        public FrmUsuarioGestion()
        {
            InitializeComponent();
            MiUsuarioLocal = new Logica.Modelos.Usuario();
            ListarUsuario = new DataTable();
        }

        private void FrmUsuarioGestion_Load(object sender, EventArgs e)
        {
            //encapsular el formulario

            MdiParent = Globales.MiFormPrincipal;
            CargarListaRoles();
            CargarListaUsuarios();
            ActivarAgregar();
        }

        private void CargarListaUsuarios()
        {
            ListarUsuario = new DataTable();


            string FiltroBusqueda = "";
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 3)
            {
                FiltroBusqueda = TxtBuscar.Text.Trim();
            }



            if (CboxVerActivos.Checked)
            {
                ListarUsuario = MiUsuarioLocal.ListarActivos(FiltroBusqueda);
            }
            else
            {
                ListarUsuario = MiUsuarioLocal.ListarInactivos(FiltroBusqueda);
            }

            DgLista.DataSource = ListarUsuario;

        }

        private void CargarListaRoles()
        {

            Logica.Modelos.UsuarioRol MiRol = new Logica.Modelos.UsuarioRol();

            DataTable dt = new DataTable();
            dt = MiRol.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbRolesUsuario.ValueMember = "ID";
                CbRolesUsuario.DisplayMember = "Descrip";
                CbRolesUsuario.DataSource = dt;
                CbRolesUsuario.SelectedIndex = -1;
            }

        }

        private void DgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgLista.SelectedRows.Count == 1)
            {

                LimpiarFormulario();

                DataGridViewRow MiFila = DgLista.SelectedRows[0];


                int IdUsuario = Convert.ToInt32(MiFila.Cells["CidUsuario"].Value);



                MiUsuarioLocal = new Logica.Modelos.Usuario();



                MiUsuarioLocal.IdUsuario = IdUsuario;



                MiUsuarioLocal = MiUsuarioLocal.ConsultarIdRetornaUsuario();




                if (MiUsuarioLocal != null && MiUsuarioLocal.IdUsuario > 0)
                {


                    TxtIdUsuario.Text = Convert.ToString(MiUsuarioLocal.IdUsuario);

                    TxtUsuarioNombre.Text = MiUsuarioLocal.Nombre;

                    TxtUsuarioTelefono.Text = MiUsuarioLocal.Telefono;

                    TxtUsuarioEmail.Text = MiUsuarioLocal.Email;

                    TxtUsuarioDireccion.Text = MiUsuarioLocal.Direccion;


                    CbRolesUsuario.SelectedValue = MiUsuarioLocal.FkIdUsuarioRol.IdUsuarioRol;

                    ActivarEditarEliminar();

                }




            }
        }

        private void DgLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgLista.ClearSelection();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {

            LimpiarFormulario();
            DgLista.ClearSelection();
            ActivarAgregar();
        }

        private void ActivarAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void ActivarEditarEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;

        }


        private void LimpiarFormulario()
        {
            TxtIdUsuario.Clear();
            TxtUsuarioEmail.Clear();
            TxtUsuarioNombre.Clear();
            TxtUsuarioTelefono.Clear();
            TxtUsuarioDireccion.Clear();
            TxtUsuarioContrasennia.Clear();

            CbRolesUsuario.SelectedIndex = -1;
        }

        private bool ValidarDatosDigitados(bool OmitirPassword = false)
        {
            bool R = false;



            if (!string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioTelefono.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioEmail.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioDireccion.Text.Trim()) &&
                CbRolesUsuario.SelectedIndex > -1)

            {

                if (OmitirPassword)
                {
                    R = true;
                }
                else
                {
                    if (!string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()))
                    {

                        R = true;

                    }
                    else
                    {

                        MessageBox.Show("Debe digitar una contraseña !", "Error de validacion", MessageBoxButtons.OK);
                        TxtUsuarioContrasennia.Focus();
                        return false;

                    }

                }

            }
            else
            {
                if (string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()))
                {

                    MessageBox.Show("Debe digitar un nombre de usuario !", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioNombre.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtUsuarioTelefono.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una telefono !", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioTelefono.Focus();
                    return false;
                }

                if (CbRolesUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe digitar una rol !", "Error de validacion", MessageBoxButtons.OK);
                    CbRolesUsuario.Focus();
                    return false;
                }


                if (string.IsNullOrEmpty(TxtUsuarioEmail.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un email !", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioEmail.Focus();
                    return false;


                }

                if (string.IsNullOrEmpty(TxtUsuarioDireccion.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una direccion !", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioDireccion.Focus();
                    return false;

                }

            }

            return R;
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            if (ValidarDatosDigitados())
            {
                bool EmailOK;

                MiUsuarioLocal = new Logica.Modelos.Usuario();

                MiUsuarioLocal.Nombre = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.Email = TxtUsuarioEmail.Text.Trim();
                MiUsuarioLocal.Contrasenia = TxtUsuarioContrasennia.Text.Trim();
                MiUsuarioLocal.Telefono = TxtUsuarioTelefono.Text.Trim();
                MiUsuarioLocal.Direccion = TxtUsuarioDireccion.Text.Trim();

                MiUsuarioLocal.FkIdUsuarioRol.IdUsuarioRol = Convert.ToInt32(CbRolesUsuario.SelectedValue);

                EmailOK = MiUsuarioLocal.ConsultarEmail();



                if (EmailOK == false)
                {
                    string msg = string.Format("¿Desea Agregar al Usuario {0}?", MiUsuarioLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(msg, "Confirmar", MessageBoxButtons.YesNo);


                    if (respuesta == DialogResult.Yes)
                    {

                        bool ok = MiUsuarioLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("¡Usuario agregado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaUsuarios();
                        }


                    }
                    else
                    {
                        MessageBox.Show("Usuario no agregado correctamente, reintente", ":/", MessageBoxButtons.OK);

                    }

                }
                else
                {

                    if (EmailOK)

                    {
                        MessageBox.Show("Ya existe un usuario con ese email!", "Error de Validacion", MessageBoxButtons.OK);

                        return;
                    }

                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            if (ValidarDatosDigitados(true))
            {
                MiUsuarioLocal.Nombre = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.Email = TxtUsuarioEmail.Text.Trim();
                MiUsuarioLocal.Telefono = TxtUsuarioTelefono.Text.Trim();
                MiUsuarioLocal.Direccion = TxtUsuarioDireccion.Text.Trim();
                MiUsuarioLocal.Contrasenia = TxtUsuarioContrasennia.Text.Trim();

                MiUsuarioLocal.FkIdUsuarioRol.IdUsuarioRol = Convert.ToInt32(CbRolesUsuario.SelectedValue);


                if (MiUsuarioLocal.ConsultarId())
                {

                    DialogResult respuesta = MessageBox.Show("Desea modificar el usuario? ",":/", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiUsuarioLocal.Modificar())
                        {
                            MessageBox.Show("El usuario se modifico correctamente", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaUsuarios();

                        }

                    }

                }
                   
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (MiUsuarioLocal.IdUsuario > 0 && MiUsuarioLocal.ConsultarId())
            {

                if (CboxVerActivos.Checked)
                {
                    DialogResult r  = MessageBox.Show("¿Desea eliminar al usuario?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {

                        if (MiUsuarioLocal.Eliminar())
                        {
                            MessageBox.Show("El usuario ha sido eliminado correctamente !", "!!", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaUsuarios();
                        }

                    }

                }
                else
                {
                    DialogResult r = MessageBox.Show("¿Está seguro que desea activar el usuario?", "???", MessageBoxButtons.YesNo
                       , MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        if (MiUsuarioLocal.Activar())
                        {
                            MessageBox.Show("El usuario ha sido activado satisfactoriamente", ":)", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaUsuarios();
                        }

                    }

                }


            }

        }

        private void TxtUsuarioNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e);
        }

        private void TxtUsuarioEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, false, true);
        }

        private void TxtUsuarioContrasennia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e);
        }

        private void TxtUsuarioTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e);
        }

        private void TxtUsuarioDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e);
        }

        private void CboxVerActivos_CheckedChanged(object sender, EventArgs e)
        {

            CargarListaUsuarios();

            if (CboxVerActivos.Checked)
            {
                BtnEliminar.Text = "Eliminar";
            }
            else
            {
                BtnEliminar.Text = "Activar";
            }

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarListaUsuarios();
        }
    }

}
