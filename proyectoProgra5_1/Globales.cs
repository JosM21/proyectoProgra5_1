using proyectoProgra5_1.Formularios;
using System.Windows.Forms;

namespace proyectoProgra5_1
{
    public static class Globales
    {
        public static Form MiFormPrincipal = new Formularios.FrmMDI();

        public static Logica.Modelos.Usuario MiUsuarioGlobal = new Logica.Modelos.Usuario();

        public static Formularios.FrmUsuarioGestion MiFormGestionUsuario = new Formularios.FrmUsuarioGestion();

        public static Formularios.FrmAgenteGestion MiFormGestionAgente = new Formularios.FrmAgenteGestion();

        public static Formularios.FrmSucursalGestion1 MiFormSucursalGestion1 = new Formularios.FrmSucursalGestion1();

        public static Formularios.FrmInmuebleGestion MiFormGestionInmueble = new Formularios.FrmInmuebleGestion();

        public static Formularios.FrmCitaGestion MiFormGestionCita = new Formularios.FrmCitaGestion();

        public static Formularios.FrmClienteGestion1 MiFormGestionCLiente1 = new Formularios.FrmClienteGestion1();


    }

}
