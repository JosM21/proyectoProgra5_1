
using System.Data;


namespace Logica.Modelos
{
    public class TipoInmueble
    {
        public int IdTipoInmueble { get; set; }

        public string Descripcion { get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Servicios.Conexion MiCnn = new Servicios.Conexion();

            R = MiCnn.EjecutarSELECT("SPTipoInmuebleListar");

            return R;
        }
            
        

    }
}
