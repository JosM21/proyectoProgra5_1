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
    public partial class FrmSucursalGestion1 : Form
    {

        DataTable DtLista { get; set; }
        private Logica.Modelos.Sucursal1 MiSucursalLocal { get; set; }

        private DataTable ListarSucursal { get; set; }


        public FrmSucursalGestion1()
        {
            InitializeComponent();
            MiSucursalLocal = new Logica.Modelos.Sucursal1();
            ListarSucursal = new DataTable();

        }



        private void CargarListaSucursal()
        {
            Logica.Modelos.Sucursal1 MiCita = new Logica.Modelos.Sucursal1();


            DataTable dataTable = new DataTable();
            dataTable = MiCita.ListarSucursal();


            if (dataTable.Rows.Count > 0)
            {
                ListarSucursal = MiSucursalLocal.ListarSucursal();

            }

            DgLista.DataSource = ListarSucursal;

        }


        private void ActivarAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            
        }

        private void ActivarEditarEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            

        }


        private void LimpiarFormulario()
        {
            TxtIdSucursal.Clear();
            TxtNombre.Clear();
            TxtTelefono.Clear();
            TxtDireccion.Clear();
            TxtEmail.Clear();

        }

        private bool ValidarDatosDigitados()
        {
            bool R = false;



            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtTelefono.Text.Trim()) &&
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

                if (string.IsNullOrEmpty(TxtTelefono.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un telefono !", "Error de validacion", MessageBoxButtons.OK);
                    TxtTelefono.Focus();
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

        private void FrmSucursalGestion1_Load_1(object sender, EventArgs e)
        {


            MdiParent = Globales.MiFormPrincipal;
            CargarListaSucursal();
            ActivarAgregar();

        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {

                bool EmailOK;
                bool NombreOK;


                MiSucursalLocal = new Logica.Modelos.Sucursal1();

                MiSucursalLocal.NombreSucursal = TxtNombre.Text.Trim();
                MiSucursalLocal.Telefono = TxtTelefono.Text.Trim();
                MiSucursalLocal.Email = TxtEmail.Text.Trim();
                MiSucursalLocal.Direccion = TxtDireccion.Text.Trim();


                EmailOK = MiSucursalLocal.ConsultarEmail();
                NombreOK = MiSucursalLocal.ConsultarNombre();

                if (EmailOK == false && NombreOK == false)
                {
                    string msg = string.Format("¿Desea agregar la sucursal {0}?", MiSucursalLocal.NombreSucursal);

                    DialogResult respuesta = MessageBox.Show(msg, "Confirmar", MessageBoxButtons.YesNo);


                    if (respuesta == DialogResult.Yes)
                    {

                        bool ok = MiSucursalLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("¡Sucursal agregada correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaSucursal();
                        }


                    }
                    else
                    {
                        MessageBox.Show("Sucursal no agregada correctamente, reintente", ":/", MessageBoxButtons.OK);

                    }

                }
                else
                {

                    if (NombreOK)
                    {
                        MessageBox.Show("Ya existe una sucursal con ese nombre!", "Error de Validacion", MessageBoxButtons.OK);

                        return;
                    }

                    if (EmailOK)

                    {
                        MessageBox.Show("Ya existe una sucursal con ese email!", "Error de Validacion", MessageBoxButtons.OK);

                        return;
                    }

                }

            }

        }

        private void BtnModificar_Click_1(object sender, EventArgs e)
        {

            if (ValidarDatosDigitados())
            {
                MiSucursalLocal.NombreSucursal = TxtNombre.Text.Trim();

                MiSucursalLocal.Email = TxtEmail.Text.Trim();
                MiSucursalLocal.Telefono = TxtTelefono.Text.Trim();
                MiSucursalLocal.Direccion = TxtDireccion.Text.Trim();


                if (MiSucursalLocal.ConsultarId())
                {

                    DialogResult respuesta = MessageBox.Show("Desea modificar la sucursal? ", ":/", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiSucursalLocal.Modificar())
                        {
                            MessageBox.Show("La sucursal se modifico correctamente", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaSucursal();

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

        private void DgLista_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (DgLista.SelectedRows.Count == 1)
            {

                LimpiarFormulario();


                DataGridViewRow MiFila = DgLista.SelectedRows[0];


                int IdSucursal = Convert.ToInt32(MiFila.Cells["CidSucursal"].Value);



                MiSucursalLocal = new Logica.Modelos.Sucursal1();



                MiSucursalLocal.IdSucursal = IdSucursal;



                MiSucursalLocal = MiSucursalLocal.ConsultarIdRetornaSucursal();




                if (MiSucursalLocal != null && MiSucursalLocal.IdSucursal > 0)
                {


                    TxtIdSucursal.Text = Convert.ToString(MiSucursalLocal.IdSucursal);

                    TxtNombre.Text = MiSucursalLocal.NombreSucursal;

                    TxtTelefono.Text = MiSucursalLocal.Telefono;

                    TxtEmail.Text = MiSucursalLocal.Email;

                    TxtDireccion.Text = MiSucursalLocal.Direccion;

                    ActivarEditarEliminar();


                }


            }


        }


        private void DgLista_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            DgLista.ClearSelection();

        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, false, true);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e);
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }


        private void LLenarLista()
        {
            DtLista = new DataTable();

            DtLista = MiSucursalLocal.ListarSucursal( TxtBuscar.Text.Trim());

            DgLista.DataSource = DtLista;

        }

        private void TxtBuscar_TextChanged_1(object sender, EventArgs e)
        {

            if (TxtBuscar.Text.Count() > 2 || string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {

                LLenarLista();

            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }

}

