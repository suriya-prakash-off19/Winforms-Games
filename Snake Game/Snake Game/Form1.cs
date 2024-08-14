using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    public partial class Form1 : Form
    {
        private int Level;
        Point start;
        Bitmap bitmap;
        Graphics Graphics;
        int SqWith = 30;
        Random random;
        List<Point> points;
        List<Point> Obs;
        Direction move;
        List<int[]> Direction;
        bool MoveAfter = false;
        int NoOfSq;
        bool PointCreate = false;
        Point Food;
        public Form1(int level)
        {
            InitializeComponent();
            DoubleBuffered = true;
            Level = level;
            Reset();
        }
        private void Reset()
        {
            bitmap = new Bitmap(SnakeBox.Width, SnakeBox.Height);
            Graphics = Graphics.FromImage(bitmap);
            Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Graphics.Clear(Color.White);
            SnakeBox.Image = bitmap;
            SqWith = 30;
            move = Snake_Game.Direction.Up;
            NoOfSq = SnakeBox.Width / SqWith;
            Obs= new List<Point>();
            random = new Random();
            start = new Point(random.Next(1, NoOfSq - 1), random.Next(1, NoOfSq - 4));
            points = new List<Point>();
            for (int i = 0; i < 3; i++)
                points.Add(new Point(start.X, start.Y + i));
            Direction = new List<int[]>() { new int[] { 0, -1 }, new int[] { 0, 1 }, new int[] { -1, 0 }, new int[] { 1, 0 } };
            //if(Level>=2)
            //{
            //    SnakeBox.BorderStyle= BorderStyle.Fixed3D;
            //    this.Width += 5;
            //    this.Height += 5;
            //}
            //DrawSquare();
            if(Level>=3)
                CreateObstacles();
            DrawSnake();
            DrawObstacles();
            Runner.Start();
        }
        private void DrawSquare()
        {
            int i, j;
            for (i = 0; i < SnakeBox.Width; i += SqWith)
            {
                for (j = 0; j < SnakeBox.Height; j += SqWith)
                {
                    using (Pen pen = new Pen(Color.Black, 1))
                    {
                        Graphics.DrawRectangle(pen, i, j, SqWith, SqWith);
                    }
                }
            }
        }
        private void DrawSnake()
        {
            int i;
            for (i = 0; i < points.Count; i++)
            {
                Graphics.FillRectangle(Brushes.Green, points[i].X * SqWith, points[i].Y * SqWith, SqWith, SqWith);
                if (i == 0)
                {
                    if (move == Snake_Game.Direction.Up)
                    {
                        Graphics.FillEllipse(Brushes.Black, points[i].X * SqWith + 3, points[i].Y * SqWith, 7, 7);
                        Graphics.FillEllipse(Brushes.Black, points[i].X * SqWith + SqWith - 10, points[i].Y * SqWith, 7, 7);
                    }
                    if (move == Snake_Game.Direction.Down)
                    {
                        Graphics.FillEllipse(Brushes.Black, points[i].X * SqWith + 3, points[i].Y * SqWith + SqWith - 7, 7, 7);
                        Graphics.FillEllipse(Brushes.Black, points[i].X * SqWith + SqWith - 10, points[i].Y * SqWith + SqWith - 7, 7, 7);
                    }
                    if (move == Snake_Game.Direction.Left)
                    {
                        Graphics.FillEllipse(Brushes.Black, points[i].X * SqWith, points[i].Y * SqWith + 5, 7, 7);
                        Graphics.FillEllipse(Brushes.Black, points[i].X * SqWith, points[i].Y * SqWith + SqWith - 10, 7, 7);
                    }
                    if (move == Snake_Game.Direction.Right)
                    {
                        Graphics.FillEllipse(Brushes.Black, points[i].X * SqWith + SqWith - 7, points[i].Y * SqWith + 3, 7, 7);
                        Graphics.FillEllipse(Brushes.Black, points[i].X * SqWith + SqWith - 7, points[i].Y * SqWith + SqWith - 10, 7, 7);
                    }
                }
            }
        }
        private void Runner_Tick(object sender, EventArgs e)
        {
            var x = points[0];
            x.X += Direction[(int)move][0];
            x.Y += Direction[(int)move][1];
            if (x.X < 0)
            {
                x.X += NoOfSq;
            }
            if (x.Y < 0)
            {
                x.Y += NoOfSq;
            }
            if (x.X >= NoOfSq)
            {
                x.X %= NoOfSq;
            }
            if (x.Y >= NoOfSq)
            {
                x.Y %= NoOfSq;
            }
            if (points.Any(y => (y.X == x.X) && (y.Y == x.Y))|| Obs.Any(m=>((m.X == x.X) && (m.Y == x.Y))))
            {
                Runner.Stop();
                MessageBox.Show("The Game Over , Score = " + (points.Count - 3));
                Reset();
                return;
            }
            if (!(x.X == Food.X && x.Y == Food.Y))
            {
                points.RemoveAt(points.Count - 1);
            }
            else
            {
                PointCreate = !PointCreate;
            }

            points.Insert(0, x);
            Graphics.Clear(Color.White);
            //DrawSquare();
            DrawSnake();
            DrawObstacles();
            CreatePoint();
            SnakeBox.Refresh();
            MoveAfter = false;
            //MessageBox.Show(string.Join(" ", points[0]));
        }

        private void MoveSetter(object sender, KeyEventArgs e)
        {
            if (MoveAfter)
                return;
            var key = e.KeyCode;
            if ((key == Keys.Up || key == Keys.W) && move != Snake_Game.Direction.Down)
            {
                move = Snake_Game.Direction.Up;
                MoveAfter = true;
            }

            if ((key == Keys.Down || key == Keys.S) && move != Snake_Game.Direction.Up)
            {
                move = Snake_Game.Direction.Down;
                MoveAfter = true;
            }
            if ((key == Keys.Left || key == Keys.A) && move != Snake_Game.Direction.Right)
            {
                move = Snake_Game.Direction.Left;
                MoveAfter = true;
            }
            if ((key == Keys.Right || key == Keys.D) && move != Snake_Game.Direction.Left)
            {
                move = Snake_Game.Direction.Right;
                MoveAfter = true;
            }
            if (key == Keys.ShiftKey)
                Runner.Stop();
            if (key == Keys.ControlKey)
                Runner.Start();

        }
        private void CreatePoint()
        {
            if (!PointCreate)
            {

                List<Point> RemovedPointX = new List<Point>();
                int i, j;
                for (i = 0; i < NoOfSq; i++)
                {
                    for (j = 0; j < NoOfSq; j++)
                    {
                        if (!(points.Contains(new Point(i, j))|| Obs.Contains(new Point(i,j))))
                        {
                            RemovedPointX.Add(new Point(i, j));
                        }
                    }
                }
                Food = RemovedPointX[random.Next(0, RemovedPointX.Count - 1)];

                PointCreate = !PointCreate;
            }
            Rectangle form = new Rectangle(Food.X * SqWith, Food.Y * SqWith, SqWith, SqWith);
            Graphics.FillEllipse(Brushes.Blue, form);
            SnakeBox.Refresh();
        }

        private void CreateObstacles()
        {
            for(int i = 0;i < 10;i++)
                Obs.Add(new Point(random.Next(1,NoOfSq-1),random.Next(1,NoOfSq-1)));
        }
        private void DrawObstacles()
        {
            foreach(Point p in Obs)
            {
                Graphics.FillRectangle(Brushes.Red,p.X*SqWith,p.Y*SqWith,SqWith, SqWith);
            }
        }
    }
}
