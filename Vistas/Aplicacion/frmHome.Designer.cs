

namespace ControlVirtual.Vistas.Aplicacion
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            dgvTurnos = new DataGridView();
            btnSalir = new Button();
            eProvider = new ErrorProvider(components);
            btnCrearTurno = new Button();
            btnCerrarPeriodo = new Button();
            btnCambiarPeriodo = new Button();
            btnEliminarTurno = new Button();
            lblTurnos = new Label();
            lblDesde = new Label();
            lblHasta = new Label();
            kpdDesde = new ControlVirtual.Vistas.Gestion.KPDatePicker();
            kpHasta = new ControlVirtual.Vistas.Gestion.KPDatePicker();
            btnMinimizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eProvider).BeginInit();
            SuspendLayout();
            // 
            // dgvTurnos
            // 
            dgvTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTurnos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTurnos.BackgroundColor = Color.FromArgb(40, 40, 40);
            dgvTurnos.BorderStyle = BorderStyle.None;
            dgvTurnos.CausesValidation = false;
            dgvTurnos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowFrame;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(150, 150, 150, 150);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(150, 150, 150, 150);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTurnos.ColumnHeadersHeight = 25;
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(150, 150, 150, 150);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(150, 150, 150, 150);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTurnos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTurnos.EnableHeadersVisualStyles = false;
            dgvTurnos.Location = new Point(12, 38);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(150, 150, 150, 150);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(150, 150, 150, 150);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTurnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowFrame;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(150, 150, 150, 150);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(150, 150, 150, 150);
            dgvTurnos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvTurnos.Size = new Size(277, 407);
            dgvTurnos.TabIndex = 0;
            dgvTurnos.MouseClick += dgvTurnos_MouseClick;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnSalir.ForeColor = SystemColors.WindowFrame;
            btnSalir.ImageAlign = ContentAlignment.TopRight;
            btnSalir.Location = new Point(1246, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(32, 34);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // eProvider
            // 
            eProvider.ContainerControl = this;
            eProvider.Icon = (Icon)resources.GetObject("eProvider.Icon");
            // 
            // btnCrearTurno
            // 
            btnCrearTurno.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCrearTurno.FlatStyle = FlatStyle.Flat;
            btnCrearTurno.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnCrearTurno.ForeColor = SystemColors.WindowFrame;
            btnCrearTurno.Location = new Point(12, 516);
            btnCrearTurno.Name = "btnCrearTurno";
            btnCrearTurno.Size = new Size(135, 33);
            btnCrearTurno.TabIndex = 17;
            btnCrearTurno.Text = "&Crear";
            btnCrearTurno.UseVisualStyleBackColor = false;
            btnCrearTurno.Click += btnCrearTurno_Click;
            // 
            // btnCerrarPeriodo
            // 
            btnCerrarPeriodo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCerrarPeriodo.FlatStyle = FlatStyle.Flat;
            btnCerrarPeriodo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnCerrarPeriodo.ForeColor = SystemColors.WindowFrame;
            btnCerrarPeriodo.Location = new Point(152, 555);
            btnCerrarPeriodo.Name = "btnCerrarPeriodo";
            btnCerrarPeriodo.Size = new Size(133, 33);
            btnCerrarPeriodo.TabIndex = 18;
            btnCerrarPeriodo.Text = "Ce&rrar período";
            btnCerrarPeriodo.UseVisualStyleBackColor = false;
            btnCerrarPeriodo.Click += btnCerrarPeriodo_Click;
            // 
            // btnCambiarPeriodo
            // 
            btnCambiarPeriodo.AccessibleRole = AccessibleRole.None;
            btnCambiarPeriodo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCambiarPeriodo.FlatStyle = FlatStyle.Flat;
            btnCambiarPeriodo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnCambiarPeriodo.ForeColor = SystemColors.WindowFrame;
            btnCambiarPeriodo.Location = new Point(12, 555);
            btnCambiarPeriodo.Name = "btnCambiarPeriodo";
            btnCambiarPeriodo.Size = new Size(135, 33);
            btnCambiarPeriodo.TabIndex = 19;
            btnCambiarPeriodo.Text = "C&ambiar período";
            btnCambiarPeriodo.UseVisualStyleBackColor = false;
            btnCambiarPeriodo.Click += btnCambiarPeriodo_Click;
            // 
            // btnEliminarTurno
            // 
            btnEliminarTurno.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminarTurno.FlatStyle = FlatStyle.Flat;
            btnEliminarTurno.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnEliminarTurno.ForeColor = SystemColors.WindowFrame;
            btnEliminarTurno.Location = new Point(153, 516);
            btnEliminarTurno.Name = "btnEliminarTurno";
            btnEliminarTurno.Size = new Size(132, 33);
            btnEliminarTurno.TabIndex = 20;
            btnEliminarTurno.Text = "Elimi&nar";
            btnEliminarTurno.UseVisualStyleBackColor = false;
            btnEliminarTurno.Click += btnEliminarTurno_Click;
            // 
            // lblTurnos
            // 
            lblTurnos.AutoSize = true;
            lblTurnos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTurnos.ForeColor = SystemColors.WindowFrame;
            lblTurnos.Location = new Point(12, 8);
            lblTurnos.Name = "lblTurnos";
            lblTurnos.Size = new Size(61, 21);
            lblTurnos.TabIndex = 22;
            lblTurnos.Text = "Turnos";
            // 
            // lblDesde
            // 
            lblDesde.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDesde.ForeColor = SystemColors.WindowFrame;
            lblDesde.Location = new Point(12, 448);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(57, 21);
            lblDesde.TabIndex = 23;
            lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            lblHasta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHasta.ForeColor = SystemColors.WindowFrame;
            lblHasta.Location = new Point(156, 448);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(53, 21);
            lblHasta.TabIndex = 25;
            lblHasta.Text = "Hasta";
            // 
            // kpdDesde
            // 
            kpdDesde.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kpdDesde.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kpdDesde.CalendarForeColor = SystemColors.ButtonFace;
            kpdDesde.CalendarMonthBackground = SystemColors.GrayText;
            kpdDesde.CalendarTitleBackColor = SystemColors.ControlDarkDark;
            kpdDesde.CalendarTitleForeColor = SystemColors.ButtonFace;
            kpdDesde.CustomFormat = "dd/MM/yy";
            kpdDesde.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kpdDesde.Format = DateTimePickerFormat.Custom;
            kpdDesde.Location = new Point(12, 472);
            kpdDesde.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            kpdDesde.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            kpdDesde.MinimumSize = new Size(0, 20);
            kpdDesde.Name = "kpdDesde";
            kpdDesde.Size = new Size(122, 29);
            kpdDesde.TabIndex = 29;
            // 
            // kpHasta
            // 
            kpHasta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kpHasta.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kpHasta.CalendarForeColor = SystemColors.ButtonFace;
            kpHasta.CalendarMonthBackground = SystemColors.GrayText;
            kpHasta.CalendarTitleBackColor = SystemColors.ControlDarkDark;
            kpHasta.CalendarTitleForeColor = SystemColors.ButtonFace;
            kpHasta.CustomFormat = "dd/MM/yy";
            kpHasta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kpHasta.Format = DateTimePickerFormat.Custom;
            kpHasta.Location = new Point(156, 472);
            kpHasta.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            kpHasta.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            kpHasta.MinimumSize = new Size(0, 20);
            kpHasta.Name = "kpHasta";
            kpHasta.Size = new Size(122, 29);
            kpHasta.TabIndex = 30;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnMinimizar.ForeColor = SystemColors.WindowFrame;
            btnMinimizar.ImageAlign = ContentAlignment.TopRight;
            btnMinimizar.Location = new Point(1208, 2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(32, 34);
            btnMinimizar.TabIndex = 31;
            btnMinimizar.Text = "_";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(1280, 600);
            Controls.Add(btnMinimizar);
            Controls.Add(kpHasta);
            Controls.Add(kpdDesde);
            Controls.Add(lblHasta);
            Controls.Add(lblDesde);
            Controls.Add(lblTurnos);
            Controls.Add(btnEliminarTurno);
            Controls.Add(btnCambiarPeriodo);
            Controls.Add(btnCerrarPeriodo);
            Controls.Add(btnCrearTurno);
            Controls.Add(btnSalir);
            Controls.Add(dgvTurnos);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Window;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHome";
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)eProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion

        private DataGridView dgvTurnos;
        private Button btnSalir;
        private ErrorProvider eProvider;
        private Button btnCrearTurno;
        private Button btnCerrarPeriodo;
        private Button btnEliminarTurno;
        private Button btnCambiarPeriodo;
        private Label lblTurnos;
        private Label lblDesde;
        private Label lblHasta;
        private Gestion.KPDatePicker kpdDesde;
        private Gestion.KPDatePicker kpHasta;
        private Button btnMinimizar;
    }
}