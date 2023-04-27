
using Logica.Servicios;
using System;
using System.Data;
using System.Data.SqlClient;


namespace Logica.Modelos
{
    public class Agente
    {
        public int IdAgente  { get; set; }

        public string Nombre { get; set; }

        public string Cedula { get; set; }

        public string Email { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public bool Activo { get; set; }

        public Sucursal1 FkIdSucursal { get; set; }


        public Agente() 
        {

            FkIdSucursal= new Sucursal1();  
            
        }

        //funciones y metodos

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Email", this.Email));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));
            

            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdSucursal", this.FkIdSucursal.IdSucursal));


            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPAgenteAgregar");

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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdAgente", this.IdAgente));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Email", this.Email));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdSucursal", this.FkIdSucursal.IdSucursal));

           

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPAgenteModificar");

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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdAgente", this.IdAgente));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPAgenteDesactivar");

            if (respuesta > 0)
            {

                R = true;

            }

            return R;
        }

        public bool Activar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdAgente", this.IdAgente));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPAgenteActivar");

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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Id", this.IdAgente));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPAgenteConsultarId");


            if (dt != null && dt.Rows.Count > 0)
            {

                R = true;


            }

            return R;

        }

        public Agente ConsultarIdRetornaAgente()
        {
            Agente R = new Agente();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Id", this.IdAgente));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPAgenteConsultarId");


            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                R.IdAgente = Convert.ToInt32(dr["idAgente"]);
                R.Nombre = Convert.ToString(dr["nombre"]);
                R.Cedula = Convert.ToString(dr["cedula"]);
                R.Email = Convert.ToString(dr["email"]);
                R.Telefono = Convert.ToString(dr["telefono"]);
                R.Direccion = Convert.ToString(dr["direccion"]);



                R.FkIdSucursal.IdSucursal = Convert.ToInt32(dr["idSucursal"]);
                R.FkIdSucursal.NombreSucursal = Convert.ToString(dr["nombreSucursal"]);


            }

            return R;
        }

        public bool ConsultarCedula()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));

            DataTable consulta = new DataTable();

            consulta = MiCnn.EjecutarSELECT("SPAgenteConsultarCedula");

            if(consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public bool ConsultarEmail()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Email", this.Email));

            DataTable consulta = new DataTable();

            consulta = MiCnn.EjecutarSELECT("SPAgenteConsultarEmail");

            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;

        }

        public DataTable ListarActivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPAgenteListar");

            return R;
        }

        public DataTable ListarInactivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", false));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPAgenteListar");

            return R;
        }






    }
}
