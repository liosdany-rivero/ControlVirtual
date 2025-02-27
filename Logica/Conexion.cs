using System.Configuration;

namespace ControlVirtual.Logica
{
    public class Conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
    }
}
