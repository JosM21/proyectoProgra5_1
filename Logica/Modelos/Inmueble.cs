
using Logica.Servicios;
using System;
using System.Data;
using System.Data.SqlClient;


namespace Logica.Modelos
{
    public class Inmueble
    {
        public int IdInmueble { get; set; }

        public string NumeroLote { get; set; }

        public string Precio { get; set; }

        public string TamanioTerreno { get; set; }

        public string TamanioConstruccion { get; set; }

        public string CantidadHabitacion { get; set; }

        public string CantidadBanio { get; set; }

        public bool Activo { get; set; }

        public string Descripcion { get; set; }

        public TipoInmueble FkIdTipoInmueble { get; set; }

        public Cliente1 FkIdContacto { get; set; }

        
        public Inmueble()
        {
            FkIdTipoInmueble = new TipoInmueble();
            FkIdContacto = new Cliente1();
        }

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@NumeroLote", this.NumeroLote));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Precio", this.Precio));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Terreno", this.TamanioTerreno));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Construccion", this.TamanioConstruccion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Habitacion", this.CantidadHabitacion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Banio", this.CantidadHabitacion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Descripcion", this.Descripcion));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@TipoInmueble", this.FkIdTipoInmueble.IdTipoInmueble));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdContacto", this.FkIdContacto.IdCliente));


            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPInmuebleAgregar");

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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdInmueble", this.IdInmueble));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@NumeroLote", this.IdInmueble));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Precio", this.Precio));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Terreno", this.TamanioConstruccion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Construccion", this.TamanioConstruccion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Habitacion", this.CantidadHabitacion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Banio", this.CantidadBanio));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Descripcion", this.Descripcion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@TipoInmueble", this.FkIdTipoInmueble.Descripcion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdContacto", this.FkIdContacto.IdCliente));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPInmuebleModificar");

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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdInmueble", this.IdInmueble));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPInmuebleDesactivar");

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
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdInmueble", this.IdInmueble));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPInmuebleActivar");

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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Id", this.IdInmueble));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPInmuebleConsultarId");


            if (dt != null && dt.Rows.Count > 0)
            {

                R = true;


            }

            return R;
        }

        public bool ConsultarNumeroLote()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Lote", this.NumeroLote));

            DataTable consulta = new DataTable();

            consulta = MiCnn.EjecutarSELECT("SPInmuebleConsultarLote");

            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));

            R = MiCnn.EjecutarSELECT("SPInmuebleListar");

            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", false));

            R = MiCnn.EjecutarSELECT("SPInmuebleListar");

            return R;
        }

        public Inmueble ConsultarIdRetornaInmueble()
        {
            Inmueble R = new Inmueble();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Id", this.IdInmueble));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPInmuebleConsultarId");

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                R.IdInmueble = Convert.ToInt32(dr["idInmueble"]);

                R.NumeroLote = Convert.ToString(dr["numerolote"]);
                R.Precio = Convert.ToString(dr["precio"]);

                R.TamanioTerreno = Convert.ToString(dr["tamanioTerreno"]);
                R.TamanioConstruccion = Convert.ToString(dr["tamanioConstruccion"]);
                R.CantidadHabitacion = Convert.ToString(dr["cantidadHabitacion"]);
                R.CantidadBanio = Convert.ToString(dr["cantidadBanio"]);
                R.Descripcion = Convert.ToString(dr["descripcion"]);



                R.FkIdTipoInmueble.IdTipoInmueble = Convert.ToInt32(dr["idTipoInmueble"]);
                R.FkIdTipoInmueble.Descripcion = Convert.ToString(dr["descripcionTipoInmueble"]);

                R.FkIdContacto.IdCliente = Convert.ToInt32(dr["idCliente"]);
                R.FkIdContacto.Nombre = Convert.ToString(dr["nombre"]);
            }

            return R;
        }


    }
}
