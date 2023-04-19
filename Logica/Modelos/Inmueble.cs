
using System.Data;


namespace Logica.Modelos
{
    public class Inmueble
    {
        public int IdInmueble { get; set; }

        public string NumeroLote { get; set; }

        public string Precio { get; set; }

        public string TamanioTerreno { get; set; }

        public string TamanioConstruccion { get; set; }

        public int CantidadHabitacion { get; set; }

        public int CantidadBanio { get; set; }

        public string Garage { get; set; }

        public string Descripcion { get; set; }

        public bool Alquiler { get; set; }


        public bool Agregar()
        {
            bool R = false;

            //ACA VA EL CODIGO DEL PROCEDIMIENTO ALMACENADO INSERT

            return R;
        }


        public bool Editar()
        {

            bool R = false;

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarId()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarNumeroLote()
        {
            bool R = false;

            return R;
        }

        public DataTable ListarAlquiler()
        {
            DataTable R = new DataTable();

            return R;
        }

        public DataTable ListarVenta()
        {
            DataTable R = new DataTable();

            return R;
        }


    }
}
