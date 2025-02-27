using ControlVirtual.Logica;
using ControlVirtual.Modelos;
using ControlVirtual.Vistas.Gestion;


namespace ControlVirtual.Vistas
{
    public partial class frmProductos : Form
    {
        private int nuevoProductoId;

        // Metodos de formulario

        public frmProductos()
        {
            InitializeComponent();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            nuevoProductoId = ProductoLogica.Instancia.UltimoId() + 1;
        }

        private void frmProductos_MouseDown(object sender, MouseEventArgs e)
        {
            MoverFormularios.ReleaseCapture();
            MoverFormularios.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dgvProductos_MouseClick(object sender, MouseEventArgs e)
        {

            var hitTestInfo = dgvProductos.HitTest(e.X, e.Y);

            if (hitTestInfo.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[hitTestInfo.RowIndex];
                txtProductoId.Text = fila.Cells["ProductoId"].Value?.ToString();
                txtProducto.Text = fila.Cells["Producto"].Value?.ToString();
                txtCosto.Text = fila.Cells["Costo"].Value?.ToString();
                txtVenta.Text = fila.Cells["Venta"].Value?.ToString();
            }
        }

        // Metodos de controles de formulario

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = ProductoLogica.Instancia.Listar();
            dgvProductos.Columns["ProductoId"].HeaderText = "Código";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            dgvProductos.DataSource = null;
            dgvProductos.Columns.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {

                txtProductoId.Text = nuevoProductoId.ToString();

                // Validaciones

                bool esValido = true;
                bool esValidoParcial = true;

                esValidoParcial = Validacion.ValidarControlNumero(txtVenta, eProvider, false);
                if (esValido)
                {
                    esValido = esValidoParcial;
                }

                esValidoParcial = Validacion.ValidarControlNumero(txtCosto, eProvider, true);
                if (esValido)
                {
                    esValido = esValidoParcial;
                }

                esValidoParcial = Validacion.ValidarControlNombre(txtProducto, eProvider);
                if (esValido)
                {
                    esValido = esValidoParcial;
                }

                esValidoParcial = Validacion.ValidarControlCodigo(txtProductoId, eProvider, nuevoProductoId);
                if (esValido)
                {
                    esValido = esValidoParcial;
                }

                // Si pasa todas las validaciones
                if (esValido)
                {
                    Productos Objeto = new Productos()
                    {
                        ProductoId = int.Parse(txtProductoId.Text),
                        Producto = txtProducto.Text.Trim(),
                        Costo = double.Parse(txtCosto.Text),
                        Venta = double.Parse(txtVenta.Text),
                    };

                    bool respuesta = ProductoLogica.Instancia.Crear(Objeto);
                    if (respuesta)
                    {
                        Buscar();
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
            try
            {
                // TODO: Desarrollar algo que me permita ver en cuantos dias se está usando el producto que se quiere editar

                // Validaciones

                bool esValido = true;
                bool esValidoParcial = true;

                esValidoParcial = Validacion.ValidarControlNumero(txtVenta, eProvider, false);
                if (esValido)
                {
                    esValido = esValidoParcial;
                }

                esValidoParcial = Validacion.ValidarControlNumero(txtCosto, eProvider, true);
                if (esValido)
                {
                    esValido = esValidoParcial;
                }

                esValidoParcial = Validacion.ValidarControlNombre(txtProducto, eProvider);
                if (esValido)
                {
                    esValido = esValidoParcial;
                }

                // Si pasa todas las validaciones
                if (esValido)
                {
                    DialogResult result = MessageBox.Show("¿Deseas editar este producto?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Productos Objeto = new Productos()
                        {
                            ProductoId = int.Parse(txtProductoId.Text),
                            Producto = txtProducto.Text,
                            Costo = double.Parse(txtCosto.Text),
                            Venta = double.Parse(txtVenta.Text)
                        };

                        bool respuesta = ProductoLogica.Instancia.Editar(Objeto);
                        if (respuesta)
                        {
                            Buscar();
                            Limpiar();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción aquí
                // TODO: Implementar un log ddonde se reporte la excepcion
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // TODO: Desarrollar algo que me permita ver en cuantos dias se está usando el producto que se quiere eliminar

            Productos Objeto = new Productos()
            {
                ProductoId = int.Parse(txtProductoId.Text)
            };

            bool respuesta = ProductoLogica.Instancia.Eliminar(Objeto);
            if (respuesta)
            {
                Buscar();
                Limpiar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //  Metodos generales

        public void Limpiar()
        {
            txtProductoId.Text = "";
            txtProducto.Text = "";
            txtCosto.Text = "";
            txtVenta.Text = "";
            txtProductoId.Focus();
            Validacion.LimpiarTodosErrores(this, eProvider);
        }

        public void Buscar()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = ProductoLogica.Instancia.Buscar(txtProductoId.Text, txtProducto.Text, txtCosto.Text, txtVenta.Text);
            dgvProductos.Columns["ProductoId"].HeaderText = "Código";
        }
    }
}
