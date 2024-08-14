using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class RoundedPanel : Panel
    {

        private int BorderRadius = 0;
        public RoundedPanel()
        {
            typeof(RoundedPanel).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.SetProperty | BindingFlags.Instance, null, this, new object[] { true });
            
            Size = new Size(32, 44);
            DoubleBuffered = true;
        }
        [Category("BorderView")]
        public int BorderRadius1
        {
            get => BorderRadius;
            set
            {
                BorderRadius = value;
                Invalidate();
            }
        }

     
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            SuspendLayout();
            graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            var RectangleSurface = new Rectangle(0, 0, Width, Height);
            if (BorderRadius1 > 1)
            {
                using (GraphicsPath PathSurface = GetFigure(RectangleSurface, BorderRadius1))
                using (Pen PenSurface = new Pen( BackColor, BorderRadius1) )
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
        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            Invalidate();
        }
    }
}
