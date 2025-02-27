

namespace ControlVirtual.Vistas
{
    partial class frmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            dgvProductos = new DataGridView();
            lblProductoId = new Label();
            lblProducto = new Label();
            lblCosto = new Label();
            lblVenta = new Label();
            txtProductoId = new TextBox();
            txtProducto = new TextBox();
            txtCosto = new TextBox();
            txtVenta = new TextBox();
            lblProductos = new Label();
            btnCrear = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            btnListar = new Button();
            eProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eProvider).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductos.BackgroundColor = Color.FromArgb(50, 50, 50);
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.CausesValidation = false;
            dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(240, 250, 240);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeight = 25;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(240, 250, 240);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.Location = new Point(19, 44);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(240, 250, 240);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(240, 250, 240);
            dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvProductos.Size = new Size(703, 313);
            dgvProductos.TabIndex = 0;
            dgvProductos.MouseClick += dgvProductos_MouseClick;
            // 
            // lblProductoId
            // 
            lblProductoId.AutoSize = true;
            lblProductoId.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProductoId.ForeColor = Color.FromArgb(150, 150, 150);
            lblProductoId.Location = new Point(19, 373);
            lblProductoId.Name = "lblProductoId";
            lblProductoId.Size = new Size(65, 21);
            lblProductoId.TabIndex = 1;
            lblProductoId.Text = "Código";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProducto.ForeColor = Color.FromArgb(150, 150, 150);
            lblProducto.Location = new Point(160, 373);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(80, 21);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Producto";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCosto.ForeColor = Color.FromArgb(150, 150, 150);
            lblCosto.Location = new Point(503, 373);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(53, 21);
            lblCosto.TabIndex = 3;
            lblCosto.Text = "Costo";
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblVenta.ForeColor = Color.FromArgb(150, 150, 150);
            lblVenta.Location = new Point(622, 373);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(54, 21);
            lblVenta.TabIndex = 4;
            lblVenta.Text = "Venta";
            // 
            // txtProductoId
            // 
            txtProductoId.BackColor = Color.FromArgb(50, 50, 50);
            txtProductoId.BorderStyle = BorderStyle.None;
            txtProductoId.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtProductoId.ForeColor = Color.White;
            txtProductoId.Location = new Point(19, 397);
            txtProductoId.Name = "txtProductoId";
            txtProductoId.Size = new Size(116, 22);
            txtProductoId.TabIndex = 5;
            // 
            // txtProducto
            // 
            txtProducto.BackColor = Color.FromArgb(50, 50, 50);
            txtProducto.BorderStyle = BorderStyle.None;
            txtProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtProducto.ForeColor = Color.White;
            txtProducto.Location = new Point(160, 397);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(319, 22);
            txtProducto.TabIndex = 6;
            // 
            // txtCosto
            // 
            txtCosto.BackColor = Color.FromArgb(50, 50, 50);
            txtCosto.BorderStyle = BorderStyle.None;
            txtCosto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtCosto.ForeColor = Color.White;
            txtCosto.Location = new Point(503, 397);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(93, 22);
            txtCosto.TabIndex = 7;
            // 
            // txtVenta
            // 
            txtVenta.BackColor = Color.FromArgb(50, 50, 50);
            txtVenta.BorderStyle = BorderStyle.None;
            txtVenta.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtVenta.ForeColor = Color.White;
            txtVenta.Location = new Point(622, 397);
            txtVenta.Name = "txtVenta";
            txtVenta.Size = new Size(85, 22);
            txtVenta.TabIndex = 8;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProductos.ForeColor = Color.FromArgb(150, 150, 150);
            lblProductos.Location = new Point(19, 9);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(87, 21);
            lblProductos.TabIndex = 9;
            lblProductos.Text = "Productos";
            // 
            // btnCrear
            // 
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnCrear.ForeColor = Color.FromArgb(150, 150, 150, 150);
            btnCrear.Location = new Point(388, 439);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(79, 33);
            btnCrear.TabIndex = 10;
            btnCrear.Text = "&Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnEditar.ForeColor = Color.FromArgb(150, 150, 150, 150);
            btnEditar.Location = new Point(473, 439);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(79, 33);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.FromArgb(150, 150, 150, 150);
            btnEliminar.Location = new Point(558, 439);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(79, 33);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Elimina&r";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(150, 150, 150, 150);
            btnSalir.Location = new Point(643, 439);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(79, 33);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.FromArgb(150, 150, 150, 150);
            btnBuscar.Location = new Point(303, 439);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(79, 33);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "&Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.FromArgb(150, 150, 150, 150);
            btnLimpiar.Location = new Point(218, 439);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(79, 33);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Lim&piar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnListar
            // 
            btnListar.FlatStyle = FlatStyle.Flat;
            btnListar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnListar.ForeColor = Color.FromArgb(150, 150, 150, 150);
            btnListar.Location = new Point(133, 439);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(79, 33);
            btnListar.TabIndex = 16;
            btnListar.Text = "&Listar";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += btnListar_Click;
            // 
            // eProvider
            // 
            eProvider.ContainerControl = this;
            eProvider.Icon = (Icon)resources.GetObject("eProvider.Icon");
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(737, 490);
            Controls.Add(btnListar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnCrear);
            Controls.Add(lblProductos);
            Controls.Add(txtVenta);
            Controls.Add(txtCosto);
            Controls.Add(txtProducto);
            Controls.Add(txtProductoId);
            Controls.Add(lblVenta);
            Controls.Add(lblCosto);
            Controls.Add(lblProducto);
            Controls.Add(lblProductoId);
            Controls.Add(dgvProductos);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Window;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProductos";
            Load += Producto_Load;
            MouseDown += frmProductos_MouseDown;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)eProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion

        private DataGridView dgvProductos;
        private Label lblProductoId;
        private Label lblProducto;
        private Label lblCosto;
        private Label lblVenta;
        private TextBox txtProductoId;
        private TextBox txtProducto;
        private TextBox txtCosto;
        private TextBox txtVenta;
        private Label lblProductos;
        private Button btnCrear;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnSalir;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnListar;
        private ErrorProvider eProvider;
    }
}