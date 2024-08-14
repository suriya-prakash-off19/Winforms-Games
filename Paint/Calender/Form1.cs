using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Calender
{
    public partial class Form1 : Form
    {
        Point px, py;
        Graphics Graphics;
        Color PenColor;
        bool paint;
        Pen Pen;
        Bitmap btm;
        Stack<Bitmap> Undo, Redo;
        int index;
        int x, y, Cx, Cy, Sx, Sy;
        ColorDialog ColorDialog;
        public Form1()
        {
            InitializeComponent();
            paint = false;
            btm = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            Graphics = Graphics.FromImage(btm);
            Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Graphics.Clear(Color.White);
            pictureBox1.Image = btm;
            Pen = new Pen(Color.Red, 2);
            Undo = new Stack<Bitmap>();
            Redo = new Stack<Bitmap>();
            Undo.Push(new Bitmap(btm));
            index = 1;
            PenColor = Color.Red;
            ColorCarry.BackColor = Color.Red;
            ColorDialog = new ColorDialog();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void Paintstar(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.InterpolationMode = InterpolationMode.High;
            Point[] points = new Point[] { new Point(100, 100), new Point(100, 300), new Point(300, 300), new Point(300, 100)};
            Point[] points2 = new Point[] { new Point(100 + 5, 100 + 5), new Point(100+5, 300 - 5), new Point(300 - 5, 300 + 5), new Point(300 - 5, 100 - 5)};
            GraphicsPath graphicsPaht = new GraphicsPath();
            //graphicsPaht.AddPolygon(points);
            graphics.DrawPolygon(new Pen(Brushes.IndianRed,20), points);
            graphics.FillPolygon(Brushes.Indigo,points2);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            px = e.Location;
            Cx = px.X;
            Cy = px.Y;
            Redo.Clear();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(paint)
            {
                if (index == 1)
                {
                    Pen = new Pen(PenColor, 2);
                    py = e.Location;
                    Graphics.DrawLine(Pen, px, py);
                    px = py;
                }
                else if (index == 2)
                {
                    Pen = new Pen(Color.White, 15);
                    py = e.Location;
                    Graphics.DrawLine(Pen, px, py);
                    px = py;
                }
                else
                {
                    Pen = new Pen(PenColor, 2);
                }
                
            }
            pictureBox1.Refresh();
            x = e.X;
            y = e.Y;
            Sx = e.X - Cx;
            Sy = e.Y - Cy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics.Clear(Color.White);
            while(Undo.Count!=0)
            {
                var x=Undo.Pop();
                x.Dispose();
            }
            while (Redo.Count != 0)
            {

                var x= Redo.Pop();
                x.Dispose();
            }
            pictureBox1.Refresh();
            Undo.Push(new Bitmap(pictureBox1.Image));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            index = 5;
            Invalidate();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if(Undo.Count!=1)
            {
                Redo.Push(Undo.Pop());
                var x = new Bitmap(Undo.Peek()) ;
                Graphics = Graphics.FromImage(x);
                pictureBox1.Image = x;
            }
            pictureBox1.Refresh();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            if (Redo.Count != 0)
            {
                var x = Redo.Pop();
                Graphics = Graphics.FromImage(x);
                pictureBox1.Image = x;
                Undo.Push(new Bitmap(x));
            }
            pictureBox1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ColorDialog.ShowDialog();
            PenColor=ColorDialog.Color;
            ColorCarry.BackColor = PenColor;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if(paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(Pen, Cx - 10, Cy - 10, Sx + 20, Sy + 20);
                }
                if (index == 4)
                {
                    g.DrawRectangle(Pen, Math.Min(Cx, x), Math.Min(Cy, y), Math.Abs(Sx), Math.Abs(Sy));
                }
                if (index == 5)
                {
                    g.DrawLine(Pen, Cx, Cy, x, y);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics = Graphics.FromImage(btm);
            Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Graphics.Clear(Color.White);
            Undo = new Stack<Bitmap>();
            Undo.Push(new Bitmap(btm));
            pictureBox1.Image = btm;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            index = 2;
            Invalidate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            index = 1;

            Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = 3;
            Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index = 4;
            Invalidate();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            Sx = x - Cx;
            Sy = y - Cy;
            if (index==3)
            {
                Graphics.DrawEllipse(Pen, Cx-10, Cy-10, Sx+20, Sy+20);
            }
            if(index==4)
            {
                Graphics.DrawRectangle(Pen,Math.Min(Cx,x),Math.Min(Cy,y),Math.Abs(Sx), Math.Abs( Sy));
            }
            if(index==5)
            {
                Graphics.DrawLine(Pen, Cx, Cy, x, y);
            }
            Undo.Push(new Bitmap(pictureBox1.Image));
        }
    }
}
