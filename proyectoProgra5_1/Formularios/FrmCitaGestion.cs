using Logica.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace proyectoProgra5_1.Formularios
{
    public partial class FrmCitaGestion : Form
    {

        public Logica.Modelos.Cita MiCitaLocal { get; set; }

        public DataTable ListarCita { get; set; }

        DataTable DtLista { get; set; }

        public FrmCitaGestion()
        {
            InitializeComponent();
            MiCitaLocal = new Logica.Modelos.Cita();
            ListarCita = new DataTable();
        }

        private void FrmCitaGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;
            CargarListaCita();
            ActivarAgregar();
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

        private void CargarListaCita()
        {
            Logica.Modelos.Cita MiCita = new Logica.Modelos.Cita();

            DataTable dataTable = new DataTable();
            dataTable = MiCita.Listar();


            if (dataTable.Rows.Count > 0)
            {
                ListarCita = MiCitaLocal.Listar();

            }

            DgLista.DataSource = ListarCita;

        }

        private void DgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DgLista.SelectedRows.Count == 1)
            {

                LimpiarFormulario();

                DataGridViewRow MiFila = DgLista.SelectedRows[0];


                int IdCita = Convert.ToInt32(MiFila.Cells["CidCita"].Value);



                MiCitaLocal = new Logica.Modelos.Cita();



                MiCitaLocal.IdCita = IdCita;



                MiCitaLocal = MiCitaLocal.ConsultarIdRetornaCita();




                if (MiCitaLocal != null && MiCitaLocal.IdCita > 0)
                {


                    TxtIdCita.Text = Convert.ToString(MiCitaLocal.IdCita);

                    TxtFecha.Text = MiCitaLocal.Fecha;

                    TxtHora.Text = MiCitaLocal.Hora;

                    TxtCliente.Text = Convert.ToString(MiCitaLocal.FkIdCliente.Nombre);

                    TxtAgente.Text = Convert.ToString(MiCitaLocal.FkIdAgente.Nombre);

                    TxtInmueble.Text = Convert.ToString(MiCitaLocal.FkIdInmueble.NumeroLote);

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

        private void LimpiarFormulario()
        {
            TxtIdCita.Clear();
            TxtFecha.Clear();
            TxtHora.Clear();
            TxtCliente.Clear();
            TxtAgente.Clear();
            TxtInmueble.Clear();

        }

        private bool ValidarDatosDigitados()
        {
            bool R = false;



            if (!string.IsNullOrEmpty(TxtFecha.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtHora.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCliente.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtAgente.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtInmueble.Text.Trim()))


            {
                R = true;
            }
            else
            {

                if (string.IsNullOrEmpty(TxtFecha.Text.Trim()))
                {

                    MessageBox.Show("Debe digitar un fecha", "Error de validacion", MessageBoxButtons.OK);
                    TxtFecha.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtHora.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una hora", "Error de validacion", MessageBoxButtons.OK);
                    TxtHora.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtCliente.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un cliente ", "Error de validacion", MessageBoxButtons.OK);
                    TxtCliente.Focus();
                    return false;


                }

                if (string.IsNullOrEmpty(TxtAgente.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un agente ", "Error de validacion", MessageBoxButtons.OK);
                    TxtAgente.Focus();
                    return false;

                }

                if (string.IsNullOrEmpty(TxtInmueble.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un inmueble ", "Error de validacion", MessageBoxButtons.OK);
                    TxtInmueble.Focus();
                    return false;

                }



            }

            return R;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            if (ValidarDatosDigitados())
            {

                MiCitaLocal = new Logica.Modelos.Cita();

                MiCitaLocal.Hora = TxtHora.Text.Trim();
                MiCitaLocal.Fecha = TxtFecha.Text.Trim();

                MiCitaLocal.FkIdAgente.IdAgente = Convert.ToInt32(TxtAgente.Text);
                MiCitaLocal.FkIdCliente.IdCliente = Convert.ToInt32(TxtCliente.Text);
                MiCitaLocal.FkIdInmueble.IdInmueble = Convert.ToInt32(TxtInmueble.Text);



                if (true)
                {
                    string msg = string.Format("¿Desea agregar la cita {0}?", MiCitaLocal.IdCita);

                    DialogResult respuesta = MessageBox.Show(msg, "Confirmar", MessageBoxButtons.YesNo);


                    if (respuesta == DialogResult.Yes)
                    {

                        bool ok = MiCitaLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("¡Cita agregada correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaCita();
                        }


                    }
                    else
                    {
                        MessageBox.Show("Cita no agregada correctamente, reintente", ":/", MessageBoxButtons.OK);

                    }

                }

            }


        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            if (ValidarDatosDigitados())
            {
                MiCitaLocal.Fecha = TxtFecha.Text.Trim();
                MiCitaLocal.Hora = TxtHora.Text.Trim();

                MiCitaLocal.FkIdAgente.Nombre = Convert.ToString(MiCitaLocal.FkIdAgente.Nombre);
                MiCitaLocal.FkIdCliente.Nombre = Convert.ToString(MiCitaLocal.FkIdCliente.Nombre);
                MiCitaLocal.FkIdInmueble.NumeroLote = Convert.ToString(MiCitaLocal.FkIdInmueble.NumeroLote);


                if (MiCitaLocal.ConsultarId())
                {

                    DialogResult respuesta = MessageBox.Show("Desea modificar la cita? ", ":/", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiCitaLocal.Modificar())
                        {
                            MessageBox.Show("La cita se modifico correctamente", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaCita();

                        }

                    }

                }

            }

        }

        private void TxtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtAgente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtInmueble_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void LLenarLista()
        {
            DtLista = new DataTable();

            DtLista = MiCitaLocal.Listar(TxtBuscar.Text.Trim());

            DgLista.DataSource = DtLista;

        }


        private void TxtBuscar_TextChanged(object sender, EventArgs e)
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
