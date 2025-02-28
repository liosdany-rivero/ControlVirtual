using ControlVirtual.Logica;
using ControlVirtual.Modelos;
using ControlVirtual.Vistas.Gestion;
using System.Collections.Generic;


namespace ControlVirtual.Vistas.Aplicacion
{
    public partial class frmHome : Form
    {
        private int ultimoTurnoId;

        // Metodos de formulario

        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            ultimoTurnoId = TurnoLogica.Instancia.UltimoId();
            Listar();
        }

        private void frmHome_MouseDown(object sender, MouseEventArgs e)
        {
            MoverFormularios.ReleaseCapture();
            MoverFormularios.SendMessage(this.Handle, 0x112, 0xf012, 0);
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
                nuevoTurnoId = Validacion.ValidarControlTurno(kpdDesde, kpHasta, ultimoTurnoId, eProvider);

                // Si pasa todas las validaciones
                if (nuevoTurnoId > 0)
                {
                    int esApertura = 0;

                    if (ultimoTurnoId == 0)
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
                        ultimoTurnoId = TurnoLogica.Instancia.UltimoId();
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

        }

        private void btnCambiarPeriodo_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarPeriodo_Click(object sender, EventArgs e)
        {

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        //  Metodos generales

        public void Listar()
        {
            dgvTurnos.DataSource = null;
            dgvTurnos.DataSource = TurnoLogica.Instancia.Listar();

            // Ocultar columnas específicas
            dgvTurnos.Columns["TurnoId"].Visible = false;
            dgvTurnos.Columns["Año"].Visible = false;
            dgvTurnos.Columns["EsApertura"].Visible = false;

            // Formatear la columna de fecha
            dgvTurnos.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvTurnos_CellFormatting);
        }

        private void dgvTurnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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


        public void Limpiar()
        {
            Validacion.LimpiarTodosErrores(this, eProvider);
        }

        private void dgvTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
