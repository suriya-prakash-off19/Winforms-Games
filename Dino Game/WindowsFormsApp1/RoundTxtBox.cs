using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    public partial class RoundTxtBox : UserControl
    {
        public RoundTxtBox()
        {
            InitializeComponent();
        }
        private Color BorderColor=Color.White;
        private int BorderRadius=1;
        private int BorderSize=1;
        public override Color BackColor
        {
            get => base.BackColor;
            set {
                base.BackColor =value;
            }
        }
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
            }
        }
        [Category("Border")]
        public int BorderRadius1
        {
            get => BorderRadius;
            set
            {
                BorderRadius = value;
                Invalidate();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateSize();
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.InterpolationMode = InterpolationMode.High;
            var RectangleSurface = new Rectangle(0, 0, Width, Height);
            if (BorderRadius > 1)
            {
                using (GraphicsPath PathSurface = GetFigure(RectangleSurface, BorderRadius1))
                using (Pen PenSurface = new Pen(Parent.BackColor, 1))
                {
                    this.Region = new Region(PathSurface);
                    e.Graphics.DrawPath(PenSurface, PathSurface);
                }
            }

        }

        private GraphicsPath GetFigure(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float CurveSize = radius;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, CurveSize, CurveSize, 180, 90);//Done
            path.AddArc(rect.Right - CurveSize, rect.Y, CurveSize, CurveSize, 270, 90);
            path.AddArc(rect.Right - CurveSize, rect.Bottom - CurveSize, CurveSize, CurveSize, 0, 90); //Done
            path.AddArc(rect.X, rect.Bottom - CurveSize, CurveSize, CurveSize, 90, 90); // Done
            path.CloseFigure();
            return path;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            Invalidate(); 
        }
        private void UpdateSize()
        {
            float FontRatio = 0.3F;
            int HeightSize = (int)(Height * FontRatio);
            textBox1.Font = new Font(Font.FontFamily, HeightSize);
            if (textBox1.Multiline == false)
            {
                int TextHeight = TextRenderer.MeasureText("Text", Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, TextHeight + 1);
                textBox1.Multiline = false;
                Height = textBox1.Height + Padding.Top + Padding.Bottom;
            }
        }
    }
}
