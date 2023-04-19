
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

            //AQUI VA EL CODIGO FUENTE QUE CARGA LA LISTA

            return R;
        }
            
        
       






    }
}
