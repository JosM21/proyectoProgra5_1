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
    public partial class FrmAgenteGestion : Form
    {

        private Logica.Modelos.Agente MiAgenteLocal { get; set; }

        private DataTable ListarAgentes { get; set; }

        public FrmAgenteGestion()
        {
            InitializeComponent();
            MiAgenteLocal = new Logica.Modelos.Agente();
            ListarAgentes = new DataTable();
        }

        private void FrmAgenteGestion_Load(object sender, EventArgs e)
        {


            MdiParent = Globales.MiFormPrincipal;
            CargarListaAgentes();
            CargarListaSucursal();
            ActivarAgregar();

        }





        private void CargarListaAgentes()
        {
            ListarAgentes = new DataTable();


            string FiltroBusqueda = "";
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 3)
            {
                FiltroBusqueda = TxtBuscar.Text.Trim();
            }



            if (CboxVerActivos.Checked)
            {
                ListarAgentes = MiAgenteLocal.ListarActivos(FiltroBusqueda);
            }
            else
            {
                ListarAgentes = MiAgenteLocal.ListarInactivos(FiltroBusqueda);
            }

            DgLista.DataSource = ListarAgentes;

        }

        private void CargarListaSucursal()
        {

            Logica.Modelos.Sucursal1 MiSucursal = new Logica.Modelos.Sucursal1();

            DataTable dt = new DataTable();
            dt = MiSucursal.ListarSucursal();

        }

        private void DgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DgLista.SelectedRows.Count == 1)
            {

                LimpiarFormulario();


                DataGridViewRow MiFila = DgLista.SelectedRows[0];


                int IdAgente = Convert.ToInt32(MiFila.Cells["CidAgente"].Value);



                MiAgenteLocal = new Logica.Modelos.Agente();



                MiAgenteLocal.IdAgente = IdAgente;



                MiAgenteLocal = MiAgenteLocal.ConsultarIdRetornaAgente();




                if (MiAgenteLocal != null && MiAgenteLocal.IdAgente > 0)
                {


                    TxtIdAgente.Text = Convert.ToString(MiAgenteLocal.IdAgente);

                    TxtNombre.Text = MiAgenteLocal.Nombre;

                    TxtCedula.Text = MiAgenteLocal.Cedula;

                    TxtTelefono.Text = MiAgenteLocal.Telefono;

                    TxtEmail.Text = MiAgenteLocal.Email;

                    TxtDireccion.Text = MiAgenteLocal.Direccion;

                    TxtSucursal.Text = Convert.ToString(MiAgenteLocal.FkIdSucursal.NombreSucursal);

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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {

            LimpiarFormulario();
            DgLista.ClearSelection();
            ActivarAgregar();
        }

        private void LimpiarFormulario()
        {
            TxtIdAgente.Clear();
            TxtNombre.Clear();
            TxtCedula.Clear();
            TxtEmail.Clear();
            TxtTelefono.Clear();
            TxtDireccion.Clear();
            TxtSucursal.Clear();

        }

        private bool ValidarDatosDigitados()
        {
            bool R = false;



            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtTelefono.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtDireccion.Text.Trim()) &&

                !string.IsNullOrEmpty(TxtSucursal.Text.Trim()))
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtNombre.Text.Trim()))
                {

                    MessageBox.Show("Debe digitar un nombre de agente !", "Error de validacion", MessageBoxButtons.OK);
                    TxtNombre.Focus();
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

                if (string.IsNullOrEmpty(TxtTelefono.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un telefono !", "Error de validacion", MessageBoxButtons.OK);
                    TxtTelefono.Focus();
                    return false;

                }

                if (string.IsNullOrEmpty(TxtDireccion.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una direccion !", "Error de validacion", MessageBoxButtons.OK);
                    TxtDireccion.Focus();
                    return false;

                }

                if (string.IsNullOrEmpty(TxtSucursal.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una sucursal !", "Error de validacion", MessageBoxButtons.OK);
                    TxtSucursal.Focus();
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

                MiAgenteLocal = new Logica.Modelos.Agente();

                MiAgenteLocal.Nombre = TxtNombre.Text.Trim();
                MiAgenteLocal.Cedula = TxtCedula.Text.Trim();
                MiAgenteLocal.Email = TxtEmail.Text.Trim();
                MiAgenteLocal.Telefono = TxtTelefono.Text.Trim();
                MiAgenteLocal.Direccion = TxtDireccion.Text.Trim();

 
                MiAgenteLocal.FkIdSucursal.IdSucursal = Convert.ToInt32(TxtSucursal.Text.Trim());

                CedulaOK = MiAgenteLocal.ConsultarCedula();
                EmailOK = MiAgenteLocal.ConsultarEmail();

                if (EmailOK == false && CedulaOK == false)
                {
                    string msg = string.Format("¿Desea agregar al agente {0}?", MiAgenteLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(msg, "Confirmar", MessageBoxButtons.YesNo);


                    if (respuesta == DialogResult.Yes)
                    {

                        bool ok = MiAgenteLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("¡Agente agregado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaAgentes();
                        }


                    }
                    else
                    {
                        MessageBox.Show("¡Agente no agregado correctamente, reintente!", ":(", MessageBoxButtons.OK);

                    }

                }
                else
                {

                    if (CedulaOK)
                    {
                        MessageBox.Show("Ya existe un agente con ese numero de cedula!", "Error de Validacion", MessageBoxButtons.OK);

                        return;
                    }

                    if (EmailOK)

                    {
                        MessageBox.Show("Ya existe un agente con ese email!", "Error de Validacion", MessageBoxButtons.OK);

                        return;
                    }
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {


            if (ValidarDatosDigitados())
            {
                MiAgenteLocal.Nombre = TxtNombre.Text.Trim();
                MiAgenteLocal.Cedula = TxtCedula.Text.Trim();
                MiAgenteLocal.Email = TxtEmail.Text.Trim();
                MiAgenteLocal.Telefono = TxtTelefono.Text.Trim();
                MiAgenteLocal.Direccion = TxtDireccion.Text.Trim();


                MiAgenteLocal.FkIdSucursal.NombreSucursal = Convert.ToString(MiAgenteLocal.FkIdSucursal.NombreSucursal);

                
                if (MiAgenteLocal.ConsultarId())
                {

                    DialogResult respuesta = MessageBox.Show("Desea modificar el agente? ", ":/", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiAgenteLocal.Modificar())
                        {
                            MessageBox.Show("El agente se modifico correctamente", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaAgentes();

                        }

                    }

                }

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (MiAgenteLocal.IdAgente > 0 && MiAgenteLocal.ConsultarId())
            {

                if (CboxVerActivos.Checked)
                {
                    DialogResult r = MessageBox.Show("¿Desea eliminar al agente?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {

                        if (MiAgenteLocal.Eliminar())
                        {
                            MessageBox.Show("El agente ha sido eliminado correctamente !", "!!", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaAgentes();
                        }

                    }

                }
                else
                {

                    DialogResult r = MessageBox.Show("¿Está seguro que desea activar el agente?", "???", MessageBoxButtons.YesNo
                       , MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        if (MiAgenteLocal.Activar())
                        {
                            MessageBox.Show("El agente ha sido activado satisfactoriamente", ":D", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaAgentes();
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

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e);
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, false, true);
        }

        private void TxtSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void CboxVerActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarListaAgentes();

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
            
            CargarListaAgentes();
        }
    }
}
