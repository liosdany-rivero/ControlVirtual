

namespace ControlVirtual.Vistas.Aplicacion
{
    partial class frmCambiarPeriodo
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            dgvTurnos = new DataGridView();
            btnSalir = new Button();
            btnSeleccionar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(150, 150, 150);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(77, 21);
            lblTitulo.TabIndex = 22;
            lblTitulo.Text = "Períodos";
            // 
            // dgvTurnos
            // 
            dgvTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTurnos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTurnos.BackgroundColor = Color.FromArgb(50, 50, 50);
            dgvTurnos.BorderStyle = BorderStyle.None;
            dgvTurnos.CausesValidation = false;
            dgvTurnos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(240, 250, 240);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTurnos.ColumnHeadersHeight = 25;
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(240, 250, 240);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTurnos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTurnos.EnableHeadersVisualStyles = false;
            dgvTurnos.Location = new Point(12, 44);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(240, 250, 240);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTurnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(240, 250, 240);
            dgvTurnos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvTurnos.Size = new Size(158, 313);
            dgvTurnos.TabIndex = 23;
            // 
            // btnSalir
            // 
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(150, 150, 150, 150);
            btnSalir.Location = new Point(196, 83);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 33);
            btnSalir.TabIndex = 24;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.FlatStyle = FlatStyle.Flat;
            btnSeleccionar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnSeleccionar.ForeColor = Color.FromArgb(150, 150, 150, 150);
            btnSeleccionar.Location = new Point(196, 44);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(100, 33);
            btnSeleccionar.TabIndex = 25;
            btnSeleccionar.Text = "S&eleccionar";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // frmCambiarPeriodo
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(323, 376);
            Controls.Add(btnSeleccionar);
            Controls.Add(btnSalir);
            Controls.Add(dgvTurnos);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Window;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCambiarPeriodo";
            MouseDown += frmCambiarPeriodo_MouseDown;
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private DataGridView dgvTurnos;
        private Button btnSalir;
        private Button btnSeleccionar;
    }
}