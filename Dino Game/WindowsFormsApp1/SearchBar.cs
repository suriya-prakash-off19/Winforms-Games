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
    public partial class SearchBar : UserControl
    {
        private int BorderRadius = 0;
        private Color BorderColor = Color.Red;
        private int BorderSize = 2;
        private bool UnderLined = false;
        public SearchBar()
        {
            InitializeComponent();
        }
        [Category("Rounded Category")]
        public int BorderRadius1
        {
            get => BorderRadius;
            set
            {
                if (value >= 0)
                    BorderRadius = value;
                Invalidate();
            }
        }

        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                TxtSearch.Font = value;
                Invalidate();
            }
        }
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                TxtSearch.ForeColor = value;
                Invalidate();
            }
        }
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                TxtSearch.BackColor = value;
                Invalidate();
            }
        }
        [Category("Rounded Category")]
        public Color BorderColor1
        {
            get => BorderColor;
            set
            {
                BorderColor = value;
                Invalidate();
            }
        }
        [Category("Rounded Category")]
        public int BorderSize1
        {
            get => BorderSize;
            set
            {
                BorderSize = value;
                Invalidate();
            }
        }
        [Category("Rounded Category")]
        public bool UnderLined1
        {
            get => UnderLined;
            set
            {
                UnderLined = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            DoubleBuffered = true;
            var RectangleSurface = new Rectangle(0, 0, Width, Height);
            var RectangleBorder = new Rectangle(1, 1, Width - 1, Height - 1);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            if (BorderRadius > 1)
            {
                using (GraphicsPath PathSurface = GetFigure(RectangleSurface, BorderRadius1))
                using (GraphicsPath PathBorder = GetFigure(RectangleBorder, BorderRadius - 1))
                using (Pen PenSurface = new Pen(Parent.BackColor, 2))
                using (Pen PenBorder = new Pen(BorderColor1, BorderRadius1))
                {
                    PenBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(PathSurface);
                    e.Graphics.DrawPath(PenSurface, PathSurface);
                    if(BorderSize1>1)
                    {
                        graphics.DrawPath(PenBorder, PathBorder);
                    }
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateSize();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateSize();
            Invalidate();
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

        private void UpdateSize()
        {
            float FontRatio = 0.4F;
            int HeightSize = (int)(Height * FontRatio);
            TxtSearch.Font = new Font(Font.FontFamily, HeightSize);
            if (TxtSearch.Multiline == false)
            {
                int TextHeight = TextRenderer.MeasureText("Text", Font).Height + 1;
                TxtSearch.Multiline = true;
                TxtSearch.MinimumSize = new Size(0, TextHeight + 1);
                TxtSearch.Multiline = false;
                Height = TxtSearch.Height + Padding.Top + Padding.Bottom;
            }
        }
    }
}
