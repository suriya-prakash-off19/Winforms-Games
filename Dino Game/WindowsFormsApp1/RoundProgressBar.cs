using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class RoundProgressBar : ProgressBar
    {
        private int BorderSize = 0;

        public RoundProgressBar()
        {
            ForeColor = Color.Black;
            BackColor = Color.White;
            Size = new Size(32, 44);
            DoubleBuffered = true;
            
        }
        [Category("Border")]
        public int BorderSize1
        {
            get => BorderSize;

            set
            {
                BorderSize = value;
                Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            DoubleBuffered = true;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.InterpolationMode = InterpolationMode.High;
            var RectangleSurface = new Rectangle(0, 0, Width, Height);
            if (BorderSize > 1)
            {
                using (GraphicsPath PathSurface = GetFigure(RectangleSurface, BorderSize))
                using (Pen PenSurface = new Pen(Parent.BackColor, 2))
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
    }
}
