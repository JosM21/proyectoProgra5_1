
using System.Data;


namespace Logica.Modelos
{
    public class Cliente
    {
        public int IdCliente { get; set; }

        public string Nombre { get; set; }

        public string Cedula { get; set; }

        public string Telefono { get;set; }

        public string Direccion { get; set; }

        public string Email { get; set; }

        public bool Activo { get; set; }


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

            public bool ConsultarCedula()
            {
                bool R = false;

                return R;
            }

            public bool ConsultarEmail()
            {
                bool R = false;

                return R;
            }

            public DataTable ListarActivos()
            {
                DataTable R = new DataTable();

                return R;
            }

            public DataTable ListarInactivos()
            {
                DataTable R = new DataTable();

                return R;
            }

        }
    }



