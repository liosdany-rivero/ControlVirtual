

namespace ControlVirtual.Vistas.Aplicacion
{
    partial class frmCerrarPeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCerrarPeriodo));
            btnSalir = new Button();
            eProvider = new ErrorProvider(components);
            btnCrear = new Button();
            lblNuevoPeriodo = new Label();
            lblDesde = new Label();
            lblHasta = new Label();
            kpdDesde = new ControlVirtual.Vistas.Gestion.KPDatePicker();
            kpHasta = new ControlVirtual.Vistas.Gestion.KPDatePicker();
            ((System.ComponentModel.ISupportInitialize)eProvider).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(150, 150, 150, 150);
            btnSalir.Location = new Point(152, 115);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(133, 34);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // eProvider
            // 
            eProvider.ContainerControl = this;
            eProvider.Icon = (Icon)resources.GetObject("eProvider.Icon");
            // 
            // btnCrear
            // 
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnCrear.ForeColor = Color.FromArgb(150, 150, 150, 150);
            btnCrear.Location = new Point(12, 115);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(133, 33);
            btnCrear.TabIndex = 18;
            btnCrear.Text = "&Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // lblNuevoPeriodo
            // 
            lblNuevoPeriodo.AutoSize = true;
            lblNuevoPeriodo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNuevoPeriodo.ForeColor = Color.FromArgb(150, 150, 150);
            lblNuevoPeriodo.Location = new Point(12, 8);
            lblNuevoPeriodo.Name = "lblNuevoPeriodo";
            lblNuevoPeriodo.Size = new Size(125, 21);
            lblNuevoPeriodo.TabIndex = 22;
            lblNuevoPeriodo.Text = "Nuevo período";
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDesde.ForeColor = Color.FromArgb(150, 150, 150);
            lblDesde.Location = new Point(16, 40);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(57, 21);
            lblDesde.TabIndex = 23;
            lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHasta.ForeColor = Color.FromArgb(150, 150, 150);
            lblHasta.Location = new Point(152, 40);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(53, 21);
            lblHasta.TabIndex = 25;
            lblHasta.Text = "Hasta";
            // 
            // kpdDesde
            // 
            kpdDesde.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kpdDesde.CalendarForeColor = SystemColors.ButtonFace;
            kpdDesde.CalendarMonthBackground = SystemColors.GrayText;
            kpdDesde.CalendarTitleBackColor = SystemColors.ControlDarkDark;
            kpdDesde.CalendarTitleForeColor = SystemColors.ButtonFace;
            kpdDesde.CustomFormat = "dd/MM/yy";
            kpdDesde.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kpdDesde.Format = DateTimePickerFormat.Custom;
            kpdDesde.Location = new Point(16, 64);
            kpdDesde.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            kpdDesde.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            kpdDesde.MinimumSize = new Size(0, 20);
            kpdDesde.Name = "kpdDesde";
            kpdDesde.Size = new Size(122, 29);
            kpdDesde.TabIndex = 29;
            // 
            // kpHasta
            // 
            kpHasta.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kpHasta.CalendarForeColor = SystemColors.ButtonFace;
            kpHasta.CalendarMonthBackground = SystemColors.GrayText;
            kpHasta.CalendarTitleBackColor = SystemColors.ControlDarkDark;
            kpHasta.CalendarTitleForeColor = SystemColors.ButtonFace;
            kpHasta.CustomFormat = "dd/MM/yy";
            kpHasta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kpHasta.Format = DateTimePickerFormat.Custom;
            kpHasta.Location = new Point(152, 64);
            kpHasta.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            kpHasta.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            kpHasta.MinimumSize = new Size(0, 20);
            kpHasta.Name = "kpHasta";
            kpHasta.Size = new Size(122, 29);
            kpHasta.TabIndex = 30;
            // 
            // frmCerrarPeriodo
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(310, 177);
            Controls.Add(kpHasta);
            Controls.Add(kpdDesde);
            Controls.Add(lblHasta);
            Controls.Add(lblDesde);
            Controls.Add(lblNuevoPeriodo);
            Controls.Add(btnCrear);
            Controls.Add(btnSalir);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Window;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCerrarPeriodo";
            MouseDown += frmCerrarPeriodo_MouseDown;
            ((System.ComponentModel.ISupportInitialize)eProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion

        private Button btnSalir;
        private ErrorProvider eProvider;
        private Button btnCrear;
        private Label lblNuevoPeriodo;
        private Label lblDesde;
        private Label lblHasta;
        private Gestion.KPDatePicker kpdDesde;
        private Gestion.KPDatePicker kpHasta;
    }
}