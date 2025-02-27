using System.Data.SQLite;

namespace ControlVirtual.Logica
{
    public class AplicacionLogica
    {
        private static AplicacionLogica _Instancia = null;

        public AplicacionLogica()
        {

        }

        public static AplicacionLogica Instancia
        {
            get
            {
                if (_Instancia == null)
                {
                    _Instancia = new AplicacionLogica();
                }
                return _Instancia;
            }
        }

        public static int ObtenerCodigoAplicacion()
        {
            int Codigo = 0;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                conexion.Open();
                string query = "SELECT MAX(AplicacionId) AS Id FROM Aplicacion";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read()) // Solo hay una fila (aunque la tabla esté vacía)
                    {
                        // Verificar si el valor es NULL
                        if (!dr.IsDBNull(dr.GetOrdinal("Id")))
                        {
                            Codigo = int.Parse(dr["Id"].ToString());
                        }
                        else
                        {
                            Codigo = VariablesGlobales.CodigoMinimo;
                        }
                    }
                }
            }
            return Codigo;
        }
    }
}
