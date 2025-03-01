using ControlVirtual.Logica;
using ControlVirtual.Modelos;
using ControlVirtual.Vistas.Gestion;
using System.Collections.Generic;
using ControlVirtual.Logica.Gestion;
using System.ComponentModel;

namespace ControlVirtual.Vistas.Aplicacion
{
    public partial class frmCambiarPeriodo : Form
    {

        // Propiedades públicas para compartir datos con el formulario principal
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object TurnoIdActual { get; private set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object TurnoIdSiguiente { get; private set; }


        public frmCambiarPeriodo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Listar();
        }

        private void frmCambiarPeriodo_MouseDown(object sender, MouseEventArgs e)
        {
            MoverFormularios.ReleaseCapture();
            MoverFormularios.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Listar()
        {
            dgvTurnos.DataSource = null;
            dgvTurnos.DataSource = TurnoLogica.Instancia.ListarApertura();

            // Ocultar columnas específicas
            dgvTurnos.Columns["TurnoId"].Visible = false;
            dgvTurnos.Columns["Año"].Visible = false;
            dgvTurnos.Columns["EsApertura"].Visible = false;
            dgvTurnos.Columns["Hasta"].Visible = false;
            dgvTurnos.Columns["Turno"].Visible = false;

            // Formatear la columna de fecha
            dgvTurnos.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvTurnos_CellFormatting);
        }

        private void dgvTurnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvTurnos.Columns[e.ColumnIndex].Name == "Desde" && e.Value != null)
                {
                    e.Value = ((DateOnly)e.Value).ToString("dd/MM/yy");
                    e.FormattingApplied = true;
                }
            }
            catch (Exception ex)
            {
                //TODO: Añadir esta exepcion al log.
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvTurnos.CurrentRow != null)
            {
                int filaSeleccionada = dgvTurnos.CurrentRow.Index;
                if (filaSeleccionada >= 0 && filaSeleccionada < dgvTurnos.Rows.Count - 1)
                {
                    TurnoIdActual = dgvTurnos.Rows[filaSeleccionada].Cells["TurnoId"].Value;
                    TurnoIdSiguiente = dgvTurnos.Rows[filaSeleccionada + 1].Cells["TurnoId"].Value;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // Mensaje en caso de no existir una fila siguiente
                    TurnoIdActual = dgvTurnos.Rows[filaSeleccionada].Cells["TurnoId"].Value;
                    TurnoIdSiguiente = null;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                // Mensaje en caso de que no haya ninguna fila seleccionada
                frmMensaje frmMsj = new frmMensaje("Por favor, selecciona una fila primero.");
            }
        }
    }
}
