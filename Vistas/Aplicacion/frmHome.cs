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

        // Controles de formulario
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Controles de turno


        private void dgvTurnos_MouseClick(object sender, MouseEventArgs e)
        {
            var hitTestInfo = dgvTurnos.HitTest(e.X, e.Y);

            if (hitTestInfo.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvTurnos.Rows[hitTestInfo.RowIndex];
                kpdDesde.Text = fila.Cells["Desde"].Value?.ToString();
                kpHasta.Text = fila.Cells["Hasta"].Value?.ToString();
                Limpiar();
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

        private void btnEliminarTurno_Click(object sender, EventArgs e)
        {
            VariablesGlobales.LaRespuestaEsSi = false;
            frmMensaje frmMsj = new frmMensaje("¿Desea eliminar el último turno?");
            frmMsj.ShowDialog();


            if (VariablesGlobales.LaRespuestaEsSi)
            {
                Turnos Objeto = new Turnos()
                {
                    TurnoId = VariablesGlobales.ultimoTurnoId
                };
                bool respuesta = TurnoLogica.Instancia.Eliminar(Objeto);
                //TODO: Aqui tengo que eliminar todas las tablas que tienen ese dia implementado cuando vaya a eliminar el TurnoID de la base de datos
                if (respuesta)
                {
                    Listar();
                    Limpiar();
                    VariablesGlobales.LaRespuestaEsSi = false;
                }
            }
        }

        private void btnCambiarPeriodo_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarPeriodo_Click(object sender, EventArgs e)
        {
            Limpiar();
            frmCerrarPeriodo frmEmergente = new frmCerrarPeriodo();
            frmEmergente.FormClosed += frmEmergente_FormClosed;
            frmEmergente.ShowDialog();
        }

        //  Metodos generales
        public void Listar()
        {
            VariablesGlobales.ultimoTurnoId = TurnoLogica.Instancia.UltimoId();
            ultimoTurnoIdApertura = TurnoLogica.Instancia.UltimoIdApertura();
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
                //TODO: Añadir esta exepcion al log.
            }
        }

        public void Limpiar()
        {
            Validacion.LimpiarTodosErrores(this, eProvider);
        }

        private void frmEmergente_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Método a ejecutar cuando el formulario emergente se cierra
            Limpiar();
            Listar();
        }
    }
}
