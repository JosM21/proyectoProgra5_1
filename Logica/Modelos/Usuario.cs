
using Logica.Servicios;
using System;
using System.Data;
using System.Data.SqlClient;


namespace Logica.Modelos
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public string Email { get; set; }

        public string Contrasenia { get; set; }

        public string Nombre { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public bool Activo { get; set; }

        public UsuarioRol FkIdUsuarioRol { get; set; }


        public Usuario ()
        {
            FkIdUsuarioRol= new UsuarioRol ();
        }

        //funciones y metodos

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion ();

            


            MiCnn.ListaDeParametros.Add(new SqlParameter("@Email", this.Email));

            //encriptar contraseña

            Crypto MiEncriptador= new Crypto ();
            string ContraseniaEncriptada = MiEncriptador.EncriptarEnUnSentido(this.Contrasenia);
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Contrasenia", ContraseniaEncriptada));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdRol", this.FkIdUsuarioRol.IdUsuarioRol));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioAgregar");

            if (resultado > 0)
            {
                R = true;

            }

            return R;
        }


        public bool Modificar()
        {

            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("IdUsuario", this.IdUsuario));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Email", this.Email));

            Crypto MiEncriptador = new Crypto();
            string ContraseniaEncriptada = MiEncriptador.EncriptarEnUnSentido(this.Contrasenia);
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Contrasenia", ContraseniaEncriptada));

           
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdRol", this.FkIdUsuarioRol.IdUsuarioRol));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioModificar");

            if (resultado > 0)
            {
                R = true;

            }

            return R;

            
        }

        public bool Eliminar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdUsuario", this.IdUsuario));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioDesactivar");

            if (respuesta > 0)
            {

                R= true;

            }


            return R;
        }

        public bool Activar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdUsuario", this.IdUsuario));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioActivar");

            if (respuesta > 0)
            {
                R = true;
            }



            return R;

        }

        public bool ConsultarId()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Id", this.IdUsuario));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPUsuarioConsultarId");

            if (dt != null && dt.Rows.Count > 0)
            {
                R = true;


            }

            return R;
        }

        public Usuario ConsultarIdRetornaUsuario()
        {
            Usuario R = new Usuario();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Id", this.IdUsuario));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPUsuarioConsultarId");

            if (dt != null && dt.Rows.Count > 0 )
            {
                DataRow dr = dt.Rows[0];

                R.IdUsuario = Convert.ToInt32(dr["idUsuario"]);
                R.Nombre = Convert.ToString(dr["nombre"]);
                R.Email = Convert.ToString(dr["email"]);
                R.Telefono = Convert.ToString(dr["telefono"]);
                R.Direccion = Convert.ToString(dr["direccion"]);
                R.Contrasenia = string.Empty;

                
                R.FkIdUsuarioRol .IdUsuarioRol = Convert.ToInt32(dr["idUsuarioRol"]);
                R.FkIdUsuarioRol.Descripcion = Convert.ToString(dr["descripcion"]);
            }

            return R;
        }

        public bool ConsultarEmail()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Email", this.Email));

            DataTable consulta = new DataTable();

            consulta = MiCnn.EjecutarSELECT("SPUsuarioConsultarEmail");

            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public DataTable ListarActivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion ();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPUsuarioListar");

            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", false));

            R = MiCnn.EjecutarSELECT("SPUsuarioListar");

            return R;
        }

        public Usuario ValidarUsuario(string pEmail, string pContrasenia)
        {

            Usuario R = new Usuario();

            Conexion MiCnn = new Conexion();

            Crypto crypto = new Crypto();
            string ContrasenniaEncriptada = crypto.EncriptarEnUnSentido(pContrasenia);



            MiCnn.ListaDeParametros.Add(new SqlParameter("@usuario", pEmail));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@password", ContrasenniaEncriptada));




            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPUsuarioValidarIngreso");

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                R.IdUsuario = Convert.ToInt32(dr["idUsuario"]);
                R.Nombre = Convert.ToString(dr["nombre"]);
                R.Email = Convert.ToString(dr["email"]);
                R.Telefono = Convert.ToString(dr["telefono"]);
                R.Direccion = Convert.ToString(dr["direccion"]);
                R.Contrasenia = string.Empty;

                //composiciones
                R.FkIdUsuarioRol.IdUsuarioRol = Convert.ToInt32(dr["idUsuarioRol"]);
                R.FkIdUsuarioRol.Descripcion = Convert.ToString(dr["descripcion"]);
                
            }

            return R;
        }





    }
}
