using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Threading;
using System.Diagnostics;

namespace Ripple
{
    /* class Ripple
     {
         public int X;
         public int Y;
         public Ripple(int x,int y)
         {
             X = x;
             Y = y;
         }
     }*/
    public class RippleButton : Button
    {
        private List<Rectangle> list;
        private List<int> Alpha;
        private bool ripple;
        private int borderRadius;
        private Color rippleColor;
        private int borderSize;
        private Color borderColor;
        private int x = 0, y = 0;
        private int height = 10, width = 10;
        public RippleButton()
        {
            list = new List<Rectangle>();
            Alpha = new List<int>();
            Size = new Size(35, 20);
            Ripple = false;
            BorderRadius = 0;
            BorderSize = 0;
            borderColor = Color.Black;
            RippleColor = Color.Black;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            this.Paint += this.RippleFunction;
            DoubleBuffered = true;
            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
        }
        [Category("Modified")]
        public bool Ripple
        {
            get => ripple;
            set
            {
                ripple = value;
                Invalidate();
            }
        }

        [Category("Modified")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                Invalidate();
            }
        }

        [Category("Modified")]
        public Color RippleColor
        {
            get => rippleColor;
            set
            {
                rippleColor = value;
                Invalidate();
            }
        }
        [Category("Modified")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                Invalidate();
            }
        }
        [Category("Modified")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                Invalidate();
            }
        }
        protected override void OnEnter(EventArgs e)
        {
            //base.OnEnter(e);
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            //base.OnMouseEnter(e);
        }
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            //base.OnMouseDown(mevent);
            height = 10; width = 10;
            x = mevent.X;
            y = mevent.Y;
            if(ripple)
            {
                list.Add(new Rectangle(x - width / 2, y - height / 2, width, height));
                Alpha.Add(80);
            }
            
            Invalidate();
        }
        protected override void OnMouseHover(EventArgs e)
        {
            //base.OnMouseHover(e);
        }
        protected override void OnClick(EventArgs e)
        {
            //base.OnClick(e);

        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.InterpolationMode = InterpolationMode.High;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            RectangleF rectSurface = new RectangleF(0, 0, Width, Height);
            RectangleF rectBorder = new RectangleF(0, 0, Width - 1, Height - 1);
            if (BorderRadius > 1)
            {
                using (GraphicsPath PathSurface = Draw(rectSurface))
                using (GraphicsPath pathBorder = Draw(rectBorder))
                using (Pen penSurface = new Pen(BackColor, 2))
                using (Pen PenBorder = new Pen(BorderColor, BorderSize))
                {
                    Region = new Region(PathSurface);
                    graphics.DrawPath(penSurface, PathSurface);
                    if (BorderSize > 2)
                    {
                        PenBorder.Alignment = PenAlignment.Inset;
                        graphics.DrawPath(PenBorder, pathBorder);
                    }
                }
            }
            else if (BorderSize > 2)
            {
                Region = new Region(rectSurface);
                using (Pen PenBorder = new Pen(BorderColor, BorderSize))
                {
                    PenBorder.Alignment = PenAlignment.Inset;
                    graphics.DrawRectangle(PenBorder, 0, 0, Width - 1, Height - 1);
                }
            }
        }

        private void RippleFunction(object sender, PaintEventArgs pevent)
        {
            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.InterpolationMode = InterpolationMode.High;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            for(int i=0;i<list.Count;i++)
            {
                Color color = Color.FromArgb(Alpha[i], RippleColor);
                using (Brush pen = new SolidBrush(color))
                {
                    try
                    {
                        graphics.FillEllipse(pen, list[i]);
                    }
                    catch
                    {

                    }
                }
                if (list[i].Width>= (int)(Width*2.5 ))
                {
                    list.RemoveAt(i);
                    Alpha.RemoveAt(i);
                    Invalidate();
                }
                else
                {
                    Rectangle rect = list[i];
                    list[i] = new Rectangle(rect.X-1, rect.Y-1, rect.Width + 2, rect.Height + 2);
                    
                    if (list[i].Width % (10+Width/400) == 0)
                        Alpha[i] -= 1;
                    if (Alpha[i] < 0)
                        Alpha[i] = 0;
                    Invalidate();
                }
            }
        }
        private GraphicsPath Draw(RectangleF rect)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            float Curve = BorderRadius;
            path.AddArc(rect.X, rect.Y, Curve, Curve, 180, 90);
            path.AddArc(rect.Right - Curve, rect.Y, Curve, Curve, 270, 90);
            path.AddArc(rect.Right - Curve, rect.Bottom - Curve, Curve, Curve, 0, 90);
            path.AddArc(rect.X, rect.Bottom - Curve, Curve, Curve, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}
