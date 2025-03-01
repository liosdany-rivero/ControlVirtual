

namespace ControlVirtual.Vistas.Aplicacion
{
    partial class frmMensajeSimple
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
            btnAceptar = new Button();
            lblTitulo = new Label();
            lblInformacion = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnAceptar.ForeColor = Color.FromArgb(150, 150, 150, 150);
            btnAceptar.Location = new Point(430, 206);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(123, 34);
            btnAceptar.TabIndex = 13;
            btnAceptar.Text = "&Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(150, 150, 150);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(56, 21);
            lblTitulo.TabIndex = 22;
            lblTitulo.Text = "Alerta";
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInformacion.ForeColor = Color.FromArgb(150, 150, 150);
            lblInformacion.Location = new Point(3, 9);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(97, 21);
            lblInformacion.TabIndex = 23;
            lblInformacion.Text = "Información.";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 50, 50);
            panel1.Controls.Add(lblInformacion);
            panel1.Location = new Point(12, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 157);
            panel1.TabIndex = 24;
            // 
            // frmMensajeSimple
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(565, 252);
            Controls.Add(panel1);
            Controls.Add(lblTitulo);
            Controls.Add(btnAceptar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Window;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMensajeSimple";
            MouseDown += frmMensajeSimple_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Label lblInformacion;
        private Panel panel1;
        private Label lblTitulo;
    }
}