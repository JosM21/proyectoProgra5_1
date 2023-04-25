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
    public partial class FrmInmuebleGestion : Form
    {

        private Logica.Modelos.Inmueble MiInmuebleLocal { get; set; }

        private DataTable ListarInmueble { get; set; }


        public FrmInmuebleGestion()
        {
            InitializeComponent();
            MiInmuebleLocal = new Logica.Modelos.Inmueble();
            ListarInmueble = new DataTable();
        }

        private void FrmInmuebleGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;
            CargarListaTipoInmueble();
            CargarListaInmueble();
            ActivarAgregar();

        }


        private void CargarListaInmueble()
        {
            ListarInmueble = new DataTable();


            string FiltroBusqueda = "";
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 3)
            {
                FiltroBusqueda = TxtBuscar.Text.Trim();
            }


            if (CboxVerActivos.Checked)
            {
                ListarInmueble = MiInmuebleLocal.ListarActivos();
            }
            else
            {
                ListarInmueble = MiInmuebleLocal.ListarInactivos();
            }

            DgLista.DataSource = ListarInmueble;
        }


        private void CargarListaTipoInmueble()
        {

            Logica.Modelos.TipoInmueble MiInmueble = new Logica.Modelos.TipoInmueble();

            DataTable dt = new DataTable();
            dt = MiInmueble.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbTipoInmueble.ValueMember = "ID";
                CbTipoInmueble.DisplayMember = "Descrip";
                CbTipoInmueble.DataSource = dt;
                CbTipoInmueble.SelectedIndex = -1;
            }

        }

        private void DgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DgLista.SelectedRows.Count == 1)
            {

                LimpiarFormulario();

                DataGridViewRow MiFila = DgLista.SelectedRows[0];


                int IdInmueble = Convert.ToInt32(MiFila.Cells["CidInmueble"].Value);



                MiInmuebleLocal = new Logica.Modelos.Inmueble();



                MiInmuebleLocal.IdInmueble = IdInmueble;



                MiInmuebleLocal = MiInmuebleLocal.ConsultarIdRetornaInmueble();




                if (MiInmuebleLocal != null && MiInmuebleLocal.IdInmueble > 0)
                {


                    TxtIdInmueble.Text = Convert.ToString(MiInmuebleLocal.IdInmueble);

                    TxtPrecio.Text = MiInmuebleLocal.Precio;

                    TxtTerreno.Text = MiInmuebleLocal.TamanioTerreno;

                    TxtBanio.Text = MiInmuebleLocal.CantidadBanio;

                    TxtLote.Text = MiInmuebleLocal.NumeroLote;

                    TxtHabitaciones.Text = MiInmuebleLocal.CantidadHabitacion;

                    TxtConstruccion.Text = MiInmuebleLocal.TamanioConstruccion;

                    TxtDescripcion.Text = MiInmuebleLocal.Descripcion;

                    TxtContacto.Text = Convert.ToString(MiInmuebleLocal.FkIdContacto.Nombre);


                    CbTipoInmueble.SelectedValue = MiInmuebleLocal.FkIdTipoInmueble.IdTipoInmueble;

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
            BtnModificar1.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void ActivarEditarEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar1.Enabled = true;
            BtnEliminar.Enabled = true;

        }


        private void BtnLimpiar_Click(object sender, EventArgs e)
        {

            LimpiarFormulario();
            DgLista.ClearSelection();
            ActivarAgregar();
        }



        private void LimpiarFormulario()
        {
            TxtIdInmueble.Clear();
            TxtLote.Clear();
            TxtPrecio.Clear();
            TxtTerreno.Clear();
            TxtConstruccion.Clear();
            TxtHabitaciones.Clear();
            TxtBanio.Clear();
            TxtDescripcion.Clear();
            TxtContacto.Clear();



            CbTipoInmueble.SelectedIndex = -1;
        }

        private bool ValidarDatosDigitados()
        {
            bool R = false;



            if (!string.IsNullOrEmpty(TxtLote.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtPrecio.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtTerreno.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtConstruccion.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtHabitaciones.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtBanio.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtDescripcion.Text.Trim()) &&

                !string.IsNullOrEmpty(TxtContacto.Text.Trim()) &&
                CbTipoInmueble.SelectedIndex > -1)



            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtLote.Text.Trim()))
                {

                    MessageBox.Show("Debe digitar un numero de lote", "Error de validacion", MessageBoxButtons.OK);
                    TxtLote.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtPrecio.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un precio !", "Error de validacion", MessageBoxButtons.OK);
                    TxtPrecio.Focus();
                    return false;
                }


                if (string.IsNullOrEmpty(TxtTerreno.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un tamaño de terreno !", "Error de validacion", MessageBoxButtons.OK);
                    TxtTerreno.Focus();
                    return false;

                }

                if (string.IsNullOrEmpty(TxtConstruccion.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un tamaño de construccion !", "Error de validacion", MessageBoxButtons.OK);
                    TxtConstruccion.Focus();
                    return false;

                }

                if (string.IsNullOrEmpty(TxtHabitaciones.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una cantidad de habitaciones !", "Error de validacion", MessageBoxButtons.OK);
                    TxtHabitaciones.Focus();
                    return false;

                }

                if (string.IsNullOrEmpty(TxtBanio.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una cantidad de baños !", "Error de validacion", MessageBoxButtons.OK);
                    TxtBanio.Focus();
                    return false;

                }

                if (string.IsNullOrEmpty(TxtDescripcion.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una descripcion !", "Error de validacion", MessageBoxButtons.OK);
                    TxtDescripcion.Focus();
                    return false;

                }

                if (string.IsNullOrEmpty(TxtContacto.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un contacto !", "Error de validacion", MessageBoxButtons.OK);
                    TxtContacto.Focus();
                    return false;

                }

                if (CbTipoInmueble.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un tipo !", "Error de validacion", MessageBoxButtons.OK);
                    CbTipoInmueble.Focus();
                    return false;

                }

            }

            return R;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            if (ValidarDatosDigitados())
            {
                bool LoteOK;


                MiInmuebleLocal = new Logica.Modelos.Inmueble();

                MiInmuebleLocal.NumeroLote = TxtLote.Text.Trim();
                MiInmuebleLocal.Precio = TxtPrecio.Text.Trim();
                MiInmuebleLocal.TamanioTerreno = TxtTerreno.Text.Trim();
                MiInmuebleLocal.TamanioConstruccion = TxtConstruccion.Text.Trim();
                MiInmuebleLocal.CantidadHabitacion = TxtHabitaciones.Text.Trim();
                MiInmuebleLocal.CantidadBanio = TxtBanio.Text.Trim();
                MiInmuebleLocal.Descripcion = TxtDescripcion.Text.Trim();

                MiInmuebleLocal.FkIdContacto.IdCliente = Convert.ToInt32(TxtContacto.Text);

                MiInmuebleLocal.FkIdTipoInmueble.IdTipoInmueble = Convert.ToInt32(CbTipoInmueble.SelectedValue);

                LoteOK = MiInmuebleLocal.ConsultarNumeroLote();


                if (LoteOK == false)
                {
                    string msg = string.Format("¿Desea agregar el inmueble {0}?", MiInmuebleLocal.NumeroLote);

                    DialogResult respuesta = MessageBox.Show(msg, "Confirmar", MessageBoxButtons.YesNo);


                    if (respuesta == DialogResult.Yes)
                    {

                        bool ok = MiInmuebleLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("¡Inmueble agregado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaInmueble();
                        }


                    }
                    else
                    {
                        MessageBox.Show("Inmueble no agregado correctamente, reintente", ":/", MessageBoxButtons.OK);

                    }

                }
                else
                {

                    if (LoteOK)
                    {
                        MessageBox.Show("Ya existe un inmueble con ese numero de Lote!", "Error de Validacion", MessageBoxButtons.OK);

                        return;
                    }


                }
            }
        }

        private void BtnModificar1_Click(object sender, EventArgs e)
        {

            if (ValidarDatosDigitados())
            {
                MiInmuebleLocal.Precio = TxtPrecio.Text.Trim();
                MiInmuebleLocal.NumeroLote = TxtLote.Text.Trim();

                MiInmuebleLocal.TamanioTerreno = TxtTerreno.Text.Trim();
                MiInmuebleLocal.TamanioConstruccion = TxtConstruccion.Text.Trim();
                MiInmuebleLocal.CantidadBanio = TxtBanio.Text.Trim();
                MiInmuebleLocal.CantidadHabitacion = TxtHabitaciones.Text.Trim();
                MiInmuebleLocal.Descripcion = TxtDescripcion.Text.Trim();


                MiInmuebleLocal.FkIdContacto.Nombre = Convert.ToString(MiInmuebleLocal.FkIdContacto.IdCliente);
                MiInmuebleLocal.FkIdTipoInmueble.Descripcion = Convert.ToString(MiInmuebleLocal.FkIdContacto.Nombre);


                if (MiInmuebleLocal.ConsultarId())
                {

                    DialogResult respuesta = MessageBox.Show("Desea modificar el inmueble? ", ":/", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiInmuebleLocal.Modificar())
                        {
                            MessageBox.Show("El inmueble se modifico correctamente", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaInmueble();

                        }

                    }

                }

            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (MiInmuebleLocal.IdInmueble > 0 && MiInmuebleLocal.ConsultarId())
            {

                if (CboxVerActivos.Checked)
                {
                    DialogResult r = MessageBox.Show("¿Desea eliminar el inmueble?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {

                        if (MiInmuebleLocal.Eliminar())
                        {
                            MessageBox.Show("El inmueble ha sido eliminado correctamente !", "!!", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaInmueble();
                        }

                    }

                }
                else
                {

                    DialogResult r = MessageBox.Show("¿Está seguro que desea activar el inmueble?", "???", MessageBoxButtons.YesNo
                       , MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        if (MiInmuebleLocal.Activar())
                        {
                            MessageBox.Show("El inmueble ha sido activado satisfactoriamente", ":)", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaInmueble();
                        }

                    }

                }


            }

        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e);
        }

        private void TxtTerreno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e);
        }

        private void TxtBanio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e);
        }

        private void TxtLote_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e);
        }

        private void TxtHabitaciones_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = Validaciones.CaracteresNumeros(e);
        }

        private void TxtConstruccion_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = Validaciones.CaracteresTexto(e);
        }

        private void TxtContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void CboxVerActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarListaInmueble();

            if (CboxVerActivos.Checked)
            {
                BtnEliminar.Text = "Eliminar";
            }
            else
            {
                BtnEliminar.Text = "Activar";
            }
        }
    }

}
