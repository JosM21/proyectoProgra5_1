using Logica.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Modelos
{
    public class Cliente1
    {
        public int IdCliente { get; set; }

        public string Nombre { get; set; }

        public string Cedula { get; set;}

        public string Telefono { get; set; }

        public string Email { get; set; }

        public string Direccion { get; set;}


        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.Email));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Email", this.Email));



            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPClienteAgregar");


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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdCliente", this.IdCliente));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Email", this.Email));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));



            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPClienteModificar");

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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdCliente", this.IdCliente));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPClienteDesactivar");

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
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdCliente", this.IdCliente));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPClienteActivar");

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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Id", this.IdCliente));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPClienteConsultarId");


            if (dt != null && dt.Rows.Count > 0)
            {

                R = true;


            }

            return R;
        }


        public Cliente1 ConsultarIdRetornaCliente()
        {
            Cliente1 R = new Cliente1();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Id", this.IdCliente));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPClienteConsultarId");

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                R.IdCliente = Convert.ToInt32(dr["idCliente"]);
                R.Nombre = Convert.ToString(dr["nombre"]);
                R.Email = Convert.ToString(dr["email"]);
                R.Cedula = Convert.ToString(dr["cedula"]);
                R.Telefono = Convert.ToString(dr["telefono"]);
                R.Direccion = Convert.ToString(dr["direccion"]);


            }

            return R;
        }


        public bool ConsultarCedula()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));

            DataTable consulta = new DataTable();

            consulta = MiCnn.EjecutarSELECT("SPClienteConsultarCedula");

            if (consulta != null && consulta.Rows.Count > 0)
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

            consulta = MiCnn.EjecutarSELECT("SPClienteConsultarEmail");

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

            R = MiCnn.EjecutarSELECT("SPClienteListar");

            return R;
        }

        public DataTable ListarInactivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();


            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", false));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPClienteListar");

            return R;
        }



    }
}
