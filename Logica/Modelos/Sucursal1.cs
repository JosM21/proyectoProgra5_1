using Logica.Servicios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Modelos
{


    public class Sucursal1
    {
        public int IdSucursal { get; set; }

        public string NombreSucursal { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public string Direccion { get; set; }


        public DataTable ListarSucursal()
        {
            DataTable R = new DataTable();
            Conexion MiCnn = new Conexion();


 
            R = MiCnn.EjecutarSELECT("SPSucursalListar");

            return R;
        }

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.NombreSucursal));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Email", this.Email));



            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPSucursalAgregar");

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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdSucursal", this.IdSucursal));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.NombreSucursal));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Email", this.Email));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));



            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPSucursalModificar");

            if (resultado > 0)
            {
                R = true;

            }

            return R;
        }


        public bool ConsultarId()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Id", this.IdSucursal));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPSucursalConsultarId");


            if (dt != null && dt.Rows.Count > 0)
            {

                R = true;


            }

            return R;
        }

        public Sucursal1 ConsultarIdRetornaSucursal()
        {
            Sucursal1 R = new Sucursal1();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Id", this.IdSucursal));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPSucursalConsultarId");

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                R.IdSucursal = Convert.ToInt32(dr["idSucursal"]);
                R.NombreSucursal = Convert.ToString(dr["nombreSucursal"]);
                R.Email = Convert.ToString(dr["email"]);
                R.Telefono = Convert.ToString(dr["telefono"]);
                R.Direccion = Convert.ToString(dr["direccion"]);


            }

            return R;
        }

        public bool ConsultarNombre()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.NombreSucursal));

            DataTable consulta = new DataTable();

            consulta = MiCnn.EjecutarSELECT("SPSucursalConsultarNombre");

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

            consulta = MiCnn.EjecutarSELECT("SPSucursalConsultarEmail");

            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;

        }


    }

}

