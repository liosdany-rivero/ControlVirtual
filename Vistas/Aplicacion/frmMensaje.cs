using ControlVirtual.Logica;
using ControlVirtual.Modelos;
using ControlVirtual.Vistas.Gestion;
using System.Collections.Generic;
using ControlVirtual.Logica.Gestion;

namespace ControlVirtual.Vistas.Aplicacion
{
    public partial class frmMensaje : Form
    {
        public frmMensaje(string Informacion)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblInformacion.Text = Informacion;
        }

        private void frmMensaje_MouseDown(object sender, MouseEventArgs e)
        {
            MoverFormularios.ReleaseCapture();
            MoverFormularios.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            VariablesGlobales.LaRespuestaEsSi = true;
            this.Close();
        }
        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
