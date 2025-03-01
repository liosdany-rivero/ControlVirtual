using ControlVirtual.Logica;
using ControlVirtual.Modelos;
using ControlVirtual.Vistas.Gestion;
using System.Collections.Generic;
using ControlVirtual.Logica.Gestion;

namespace ControlVirtual.Vistas.Aplicacion
{
    public partial class frmCerrarPeriodo : Form
    {
        private int ultimoTurnoIdApertura;

        // Metodos de formulario

        public frmCerrarPeriodo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            var ultimo = Conversiones.ObtenerPeriodo(VariablesGlobales.ultimoTurnoId);
            DateOnly nuevaFecha = ultimo.DiaFinal.AddDays(1);
            kpdDesde.Text = nuevaFecha.ToString();
            kpHasta.Text = nuevaFecha.ToString();
        }

        private void frmCerrarPeriodo_MouseDown(object sender, MouseEventArgs e)
        {
            MoverFormularios.ReleaseCapture();
            MoverFormularios.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Controles del lateral izquierdo

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        //  Metodos generales

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {

                // Validaciones
                int nuevoTurnoId = 0;
                nuevoTurnoId = Validacion.ValidarControlTurno(kpdDesde, kpHasta, VariablesGlobales.ultimoTurnoId, eProvider);

                // Si pasa todas las validaciones
                if (nuevoTurnoId > 0)
                {
                    int esApertura = 1;

                    Turnos Objeto = new Turnos()
                    {
                        TurnoId = nuevoTurnoId,
                        EsApertura = esApertura,
                    };

                    bool respuesta = TurnoLogica.Instancia.Crear(Objeto);
                    if (respuesta)
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción aquí
                // TODO: Implementar un log ddonde se reporte la excepcion
            }
        }

 

    }
}
