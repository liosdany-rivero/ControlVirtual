using ControlVirtual.Logica;
using ControlVirtual.Modelos;
using ControlVirtual.Vistas.Gestion;
using System.Collections.Generic;
using ControlVirtual;


namespace ControlVirtual.Vistas.Aplicacion
{
    public partial class frmHome : Form
    {
        private int ultimoTurnoIdApertura;

        // Metodos de formulario

        public frmHome()
        {
            InitializeComponent();
            VariablesGlobales.ultimoTurnoId = TurnoLogica.Instancia.UltimoId();
            ultimoTurnoIdApertura = TurnoLogica.Instancia.UltimoIdApertura();
            Listar();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            dgvTurnos.Height = this.Height - 194;
        }

        // Controles del lateral izquierdo
        private void dgvTurnos_MouseClick(object sender, MouseEventArgs e)
        {
            var hitTestInfo = dgvTurnos.HitTest(e.X, e.Y);

            if (hitTestInfo.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvTurnos.Rows[hitTestInfo.RowIndex];
                kpdDesde.Text = fila.Cells["Desde"].Value?.ToString();
                kpHasta.Text = fila.Cells["Hasta"].Value?.ToString();

            }
        }

        private void btnCrearTurno_Click(object sender, EventArgs e)
        {
            try
            {

                // Validaciones
                int nuevoTurnoId = 0;
                nuevoTurnoId = Validacion.ValidarControlTurno(kpdDesde, kpHasta, VariablesGlobales.ultimoTurnoId, eProvider);

                // Si pasa todas las validaciones
                if (nuevoTurnoId > 0)
                {
                    int esApertura = 0;

                    if (VariablesGlobales.ultimoTurnoId == 0)
                    {
                        esApertura = 1;
                    }

                    Turnos Objeto = new Turnos()
                    {
                        TurnoId = nuevoTurnoId,
                        EsApertura = esApertura,
                    };

                    bool respuesta = TurnoLogica.Instancia.Crear(Objeto);
                    if (respuesta)
                    {
                        VariablesGlobales.ultimoTurnoId = TurnoLogica.Instancia.UltimoId();
                        Listar();
                        Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción aquí
                // TODO: Implementar un log ddonde se reporte la excepcion
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }


        private void btnEliminarTurno_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el último turno?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Turnos Objeto = new Turnos()
                {
                    TurnoId = VariablesGlobales.ultimoTurnoId
                };

                bool respuesta = TurnoLogica.Instancia.Eliminar(Objeto);
                if (respuesta)
                {
                    VariablesGlobales.ultimoTurnoId = TurnoLogica.Instancia.UltimoId();
                    Listar();
                    Limpiar();
                }
            }
        }


        private void btnCambiarPeriodo_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarPeriodo_Click(object sender, EventArgs e)
        {
            frmCerrarPeriodo frmEmergente = new frmCerrarPeriodo();
            frmEmergente.FormClosed += frmEmergente_FormClosed;
            frmEmergente.ShowDialog();
        }

        // Controles de formulario

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //  Metodos generales

        public void Listar()
        {
            dgvTurnos.DataSource = null;
            dgvTurnos.DataSource = TurnoLogica.Instancia.Listar(ultimoTurnoIdApertura);

            // Ocultar columnas específicas
            dgvTurnos.Columns["TurnoId"].Visible = false;
            dgvTurnos.Columns["Año"].Visible = false;
            dgvTurnos.Columns["EsApertura"].Visible = false;

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
                if (dgvTurnos.Columns[e.ColumnIndex].Name == "Hasta" && e.Value != null)
                {
                    e.Value = ((DateOnly)e.Value).ToString("dd/MM/yy");
                    e.FormattingApplied = true;
                }
            }
            catch (Exception ex)
            {
                //ToDo: Añadir esta exepcion al log.
            }
        }

        public void Limpiar()
        {
            Validacion.LimpiarTodosErrores(this, eProvider);
        }

        private void frmEmergente_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Método a ejecutar cuando el formulario emergente se cierra
            VariablesGlobales.ultimoTurnoId = TurnoLogica.Instancia.UltimoId();
            ultimoTurnoIdApertura = TurnoLogica.Instancia.UltimoIdApertura();
            Limpiar();
            Listar();
        }

    }
}
