
using FluentAssertions.Common;
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

            Servicios.Conexion MiCnn = new Servicios.Conexion();

            R = MiCnn.EjecutarSELECT("SPUsuarioRolListar");

            return R;
        }

    }
}
