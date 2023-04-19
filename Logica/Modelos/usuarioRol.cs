
using System.Data;


namespace Logica.Modelos
{
    public class UsuarioRol
    {

        public int IdUsuarioRol { get; set; }

        public string Descripcion { get; set; }

        public DataTable Listar() 
        { 
            DataTable R = new DataTable();

            //AQUI VA EL CODIGO FUENTE QUE CARGA LA LISTA

            return R;
        }

    }
}
