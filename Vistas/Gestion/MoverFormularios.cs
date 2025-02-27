using System.Runtime.InteropServices;

namespace ControlVirtual.Vistas.Gestion
{
    public class MoverFormularios
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(nint hwnd, int wmsg, int wparam, int lparam);
    }
}
