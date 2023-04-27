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
    public class Cita
    {
        public int IdCita { get; set; }

        public string Fecha { get; set; }

        public string Hora { get; set; }

        public Cliente1 FkIdCliente { get; set; }

        public Agente FkIdAgente { get; set; }

        public Inmueble FkIdInmueble { get; set; }

        public Cita()
        {
            FkIdCliente = new Cliente1();
            FkIdAgente = new Agente();
            FkIdInmueble= new Inmueble();
        }


        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Fecha", this.Fecha));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Hora", this.Hora));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdAgente", this.FkIdAgente.IdAgente));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdCliente", this.FkIdCliente.IdCliente));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdInmueble", this.FkIdInmueble.IdInmueble));


            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPCitaAgregar");

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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdCita", this.IdCita));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Fecha", this.Fecha));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Hora", this.Hora));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdCliente", this.FkIdCliente.IdCliente));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdAgente", this.FkIdAgente.IdAgente));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdInmueble", this.FkIdInmueble.IdInmueble));



            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPCitaModificar");

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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Id", this.IdCita));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPCitaConsultarId");


            if (dt != null && dt.Rows.Count > 0)
            {

                R = true;


            }

            return R;

        }


        public DataTable Listar( string FiltroBusqueda = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();


           
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", FiltroBusqueda));


            R = MiCnn.EjecutarSELECT("SPCitaListar");

            return R;
        }

        public Cita ConsultarIdRetornaCita()
        {
            Cita R = new Cita();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Id", this.IdCita));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPCitaConsultarId");

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                R.IdCita = Convert.ToInt32(dr["idCita"]);
                R.Fecha = Convert.ToString(dr["fecha"]);
                R.Hora = Convert.ToString(dr["hora"]);




                R.FkIdCliente.IdCliente = Convert.ToInt32(dr["idCliente"]);
                R.FkIdCliente.Nombre = Convert.ToString(dr["nombreCliente"]);

                R.FkIdAgente.IdAgente = Convert.ToInt32(dr["idAgente"]);
                R.FkIdAgente.Nombre = Convert.ToString(dr["nombreAgente"]);

                R.FkIdInmueble.IdInmueble = Convert.ToInt32(dr["idCliente"]);
                R.FkIdInmueble.NumeroLote = Convert.ToString(dr["numeroLote"]);

            }

            return R;
        }



    }
}
