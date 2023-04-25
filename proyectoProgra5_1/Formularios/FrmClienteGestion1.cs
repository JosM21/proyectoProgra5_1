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
    public partial class FrmClienteGestion1 : Form
    {

        private Logica.Modelos.Cliente1 MiClienteLocal1 { get; set; }

        private DataTable ListarCliente1 { get; set; }

        public FrmClienteGestion1()
        {
            InitializeComponent();
            MiClienteLocal1 = new Logica.Modelos.Cliente1();
            ListarCliente1 = new DataTable();
        }

        private void FrmClienteGestion1_Load(object sender, EventArgs e)
        {

            MdiParent = Globales.MiFormPrincipal;
            CargarListaCliente();
            ActivarAgregar();
        }

        private void CargarListaCliente()
        {
            ListarCliente1 = new DataTable();


            string FiltroBusqueda = "";
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 3)
            {
                FiltroBusqueda = TxtBuscar.Text.Trim();
            }



            if (CboxVerActivos.Checked)
            {
                ListarCliente1 = MiClienteLocal1.ListarActivos(FiltroBusqueda);
            }
            else
            {
                ListarCliente1 = MiClienteLocal1.ListarInactivos();
            }

            DgLista.DataSource = ListarCliente1;
        }



        private void DgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DgLista.SelectedRows.Count == 1)
            {

                LimpiarFormulario();


                DataGridViewRow MiFila = DgLista.SelectedRows[0];


                int IdCliente = Convert.ToInt32(MiFila.Cells["CidCliente"].Value);



                MiClienteLocal1 = new Logica.Modelos.Cliente1();



                MiClienteLocal1.IdCliente = IdCliente;



                MiClienteLocal1 = MiClienteLocal1.ConsultarIdRetornaCliente();




                if (MiClienteLocal1 != null && MiClienteLocal1.IdCliente > 0)
                {


                    TxtIdCliente.Text = Convert.ToString(MiClienteLocal1.IdCliente);

                    TxtNombre.Text = MiClienteLocal1.Nombre;

                    TxtTelefonos.Text = MiClienteLocal1.Telefono;

                    TxtCedula.Text = MiClienteLocal1.Cedula;

                    TxtEmail.Text = MiClienteLocal1.Email;

                    TxtDireccion.Text = MiClienteLocal1.Direccion;

                    ActivarEditarEliminar();


                }


            }

        }

        private void DgLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            DgLista.ClearSelection();

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
            TxtIdCliente.Clear();
            TxtNombre.Clear();
            TxtCedula.Clear();
            TxtTelefonos.Clear();
            TxtDireccion.Clear();
            TxtEmail.Clear();

        }

        private bool ValidarDatosDigitados()
        {
            bool R = false;



            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtTelefonos.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtDireccion.Text.Trim()))


            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtNombre.Text.Trim()))
                {

                    MessageBox.Show("Debe digitar un nombre !", "Error de validacion", MessageBoxButtons.OK);
                    TxtNombre.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un telefono !", "Error de validacion", MessageBoxButtons.OK);
                    TxtCedula.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una cedula !", "Error de validacion", MessageBoxButtons.OK);
                    TxtCedula.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtEmail.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un email !", "Error de validacion", MessageBoxButtons.OK);
                    TxtEmail.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtDireccion.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una direccion !", "Error de validacion", MessageBoxButtons.OK);
                    TxtDireccion.Focus();
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
                bool CedulaOK;


                MiClienteLocal1 = new Logica.Modelos.Cliente1();

                MiClienteLocal1.Nombre = TxtNombre.Text.Trim();
                MiClienteLocal1.Cedula = TxtCedula.Text.Trim();
                MiClienteLocal1.Telefono = TxtTelefonos.Text.Trim();
                MiClienteLocal1.Email = TxtEmail.Text.Trim();
                MiClienteLocal1.Direccion = TxtDireccion.Text.Trim();


                EmailOK = MiClienteLocal1.ConsultarEmail();
                CedulaOK = MiClienteLocal1.ConsultarCedula();

                if (EmailOK == false && CedulaOK == false)
                {
                    string msg = string.Format("¿Desea agregar el cliente {0}?", MiClienteLocal1.Nombre);

                    DialogResult respuesta = MessageBox.Show(msg, "Confirmar", MessageBoxButtons.YesNo);


                    if (respuesta == DialogResult.Yes)
                    {

                        bool ok = MiClienteLocal1.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("¡Cliente agregado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaCliente();
                        }


                    }
                    else
                    {
                        MessageBox.Show("Cliente no agregado correctamente, reintente", ":/", MessageBoxButtons.OK);

                    }

                }
                else
                {

                    if (CedulaOK)
                    {
                        MessageBox.Show("Ya existe un cliente con esa cedula !", "Error de Validacion", MessageBoxButtons.OK);

                        return;
                    }

                    if (EmailOK)

                    {
                        MessageBox.Show("Ya existe un cliente con ese email !", "Error de Validacion", MessageBoxButtons.OK);

                        return;
                    }

                }

            }


        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            if (ValidarDatosDigitados())
            {
                MiClienteLocal1.Nombre = TxtNombre.Text.Trim();
                MiClienteLocal1.Cedula = TxtTelefonos.Text.Trim();
                MiClienteLocal1.Email = TxtEmail.Text.Trim();
                MiClienteLocal1.Cedula = TxtCedula.Text.Trim();
                MiClienteLocal1.Direccion = TxtDireccion.Text.Trim();


                if (MiClienteLocal1.ConsultarId())
                {

                    DialogResult respuesta = MessageBox.Show("Desea modificar el cliente ? ", ":/", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiClienteLocal1.Modificar())
                        {
                            MessageBox.Show("El cliente se modifico correctamente", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaCliente();

                        }

                    }

                }

            }

        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {

            LimpiarFormulario();
            DgLista.ClearSelection();
            ActivarAgregar();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (MiClienteLocal1.IdCliente > 0 && MiClienteLocal1.ConsultarId())
            {

                if (CboxVerActivos.Checked)
                {
                    DialogResult r = MessageBox.Show("¿Desea eliminar el cliente ?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {

                        if (MiClienteLocal1.Eliminar())
                        {
                            MessageBox.Show("El cliente ha sido eliminado correctamente !", "!!", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaCliente();
                        }

                    }

                }
                else
                {
                    DialogResult r = MessageBox.Show("¿Está seguro que desea activar el cliente?", "???", MessageBoxButtons.YesNo
                       , MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        if (MiClienteLocal1.Activar())
                        {
                            MessageBox.Show("El cliente ha sido activado satisfactoriamente", ":)", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaCliente();
                        }

                    }


                }


            }

        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, false, true);
        }

        private void TxtTelefonos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e);
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void CboxVerActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarListaCliente();

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
            CargarListaCliente();
        }
    }
}
