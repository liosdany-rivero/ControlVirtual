
using ControlVirtual.Logica;

namespace ControlVirtual
{
    internal static class Programa
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            VariablesGlobales.CodigoAplicacion = AplicacionLogica.ObtenerCodigoAplicacion();
            VariablesGlobales.CodigoMinimo = int.Parse(VariablesGlobales.CodigoAplicacion.ToString() + "10000");
            Application.Run(new Vistas.Aplicacion.frmHome());
        }
    }
}