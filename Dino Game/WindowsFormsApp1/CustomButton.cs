using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CustomButton : UserControl
    {
        private Color BorderColor = Color.Red;
        private int BorderSize = 2;
        private bool UnderLined = false;
        public CustomButton()
        {
            InitializeComponent();
        }
        [Category("UserCreated")]
        public Color BorderColor1
        {
            get => BorderColor;
            set
            {
                BorderColor = value;
                Invalidate();
            }
        }

        [Category("UserCreated")]
        public int BorderSize1
        {
            get => BorderSize;
            set
            {
                BorderSize = value;
                Invalidate();
            }
        }

        [Category("UserCreated")]
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
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            textBox1.BackColor = BackColor;
            using (Pen pen = new Pen(BorderColor, BorderSize))
            {
                if (UnderLined)
                    graphics.DrawLine(pen, 0, Height, Width, Height);
                else
                    graphics.DrawRectangle(pen, 0, 0, Width - 0.5F, Height - 0.5F);
            }
                
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
        
        private void UpdateSize()
        {
            float FontRatio = 0.4F;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
