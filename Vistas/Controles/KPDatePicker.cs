using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing;

namespace ControlVirtual.Vistas.Gestion
{
    public class KPDatePicker : DateTimePicker
    {
        //campos

        //apariencia
        private Color skinColor = Color.FromArgb(40, 40, 40);
        private Color textColor = Color.FromArgb(150, 150, 150, 150);
        private Color borderColor = Color.PaleVioletRed;
        private int borderSize = 0;

        // otros valores
        private bool droppedDown = false;
      //  private Image calendarIcon = Properties.Resources.icono;
        private RectangleF iconButtonArea;
        private const int calendarIconWidth = 34;
        private const int arrowIconWidth = 17;


        //propiedades
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color SkinColor
        {
            get
            {
                return skinColor;
            }
            set
            {
                skinColor = value;
                this.Invalidate();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color TextColor
        {
            get
            {
                return textColor;
            }
            set
            {
                textColor = value;
                this.Invalidate();
            }
        }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        // constuctor
        public KPDatePicker()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.MinimumSize = new Size(0, 35);
            this.Font = new Font(this.Font.Name, 9.5F);
        }

        // sobre escribiendo metodos
        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            droppedDown = true;
        }

        protected override void OnCloseUp(EventArgs eventargs)
        {
            base.OnCloseUp(eventargs);
            droppedDown = false;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Graphics graphics = this.CreateGraphics())
            using (Pen penBorder=new Pen(borderColor, borderSize))
            using (SolidBrush skinBrush = new SolidBrush(skinColor))
            using (SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(35,35,35))) //FromArgb(50,64,64,64)))
            using (SolidBrush textBrush = new SolidBrush(textColor))
            using (StringFormat textFormat = new StringFormat())
            {
                RectangleF clientArea = new RectangleF(0,0,this.Width-0.5F,this.Height-0.5F);
                RectangleF IconArea = new RectangleF(clientArea.Width-calendarIconWidth,0,calendarIconWidth,clientArea.Height);
                penBorder.Alignment = PenAlignment.Inset;
                textFormat.LineAlignment = StringAlignment.Center;

                //dibujar superficie
                graphics.FillRectangle(skinBrush, clientArea);

                //dibujar text
                graphics.DrawString("  "+this.Text, this.Font, textBrush, clientArea, textFormat);

                //dibujar el area del icono cuando el calendario esta desplegado
                if (droppedDown == true) graphics.FillRectangle(openIconBrush, IconArea);

                //dibujar borde
                if (borderSize >= 1) graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);

                //dibujar area del icono del  selector de fecha
               // graphics.DrawImage(calndario, this.Width - calendarIcon - 9, (this.Height - 28) / 2);
            
            }

        }

    }
}
