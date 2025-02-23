namespace ControlVirtual
{
    internal static class Programa
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize(); 
            Application.Run(new Vistas.Inicio());
        }
    }
}