using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo
{
    public partial class PageForm : Form
    {
        PictureBox pictureBox;
        Dictionary<PictureBox, Point> PointRed;
        Dictionary<PictureBox, Point> PointGreen;
        Dictionary<PictureBox, Point> PointBlue;
        Dictionary<PictureBox, Point> PointYellow;
        List<string> MoveName;
        int MoveNumber;
        int x = 0;
        bool Moved;
        bool[] FirstMove;
        Dictionary<string, Point> Direction;
        public PageForm()
        {
            InitializeComponent();
            Moved = true;
            Direction = new Dictionary<string, Point>();
            SetDirectionMove(Direction);
            FirstMove = new bool[] { false, false, false, false };
            pictureBox = new PictureBox();
            PointBlue = new Dictionary<PictureBox, Point>();
            PointGreen = new Dictionary<PictureBox, Point>();
            PointYellow = new Dictionary<PictureBox, Point>();
            PointRed = new Dictionary<PictureBox, Point>();
            MoveName = new List<string>() { "Red", "Blue", "Yellow", "Green" };
            MoveNumber = 0;
            this.Text = "Move : " + MoveName[MoveNumber];
        }

        private void SetDirectionMove(Dictionary<string, Point> direction)
        {
            direction.Add("Up", new Point(-60, 0));
            direction.Add("Down",new Point(60, 0));
            direction.Add("Left", new Point(0, -48));
            direction.Add("Right",new Point(0, 48));
            direction.Add("UpLeft", new Point(-60, -48));
            direction.Add("UpRight", new Point(-60, 48));
            direction.Add("DownLeft", new Point(60, -48));
            direction.Add("DownRight", new Point(60, 48));
        }

        private void DrawIcon(object s)
        {
            PictureBox pictureBox = s as PictureBox;
            pictureBox.Click += PictureClick;
            Color c = pictureBox.BackColor;
            if (pictureBox.Name.StartsWith("R"))
            {
                c = Color.DarkRed;
                PointRed.Add(pictureBox, pictureBox.Location);
            }
            else if (pictureBox.Name.StartsWith("B"))
            {
                c = Color.DarkSlateBlue;
                PointBlue.Add(pictureBox, pictureBox.Location);
            }
            else if (pictureBox.Name.StartsWith("G"))
            {
                c = Color.GreenYellow;
                PointGreen.Add(pictureBox, pictureBox.Location);
            }
            else if (pictureBox.Name.StartsWith("Y"))
            {
                c = Color.YellowGreen;
                PointYellow.Add(pictureBox, pictureBox.Location);
            }

            Bitmap bitmap = new Bitmap(100, 100);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Brush brush = new SolidBrush(c);
                g.Clear(Color.Transparent);
                g.FillEllipse(brush, 5, 5, 90, 90);
            }
            pictureBox.Image = bitmap;

        }

        private void PageForm_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.X + " " + e.Y);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void PageForm_Load(object sender, EventArgs e)
        {
            foreach (var s in this.Controls)
            {
                if (s is PictureBox)
                {
                    ((PictureBox)s).Size = new Size(60, 48);
                    ((PictureBox)s).BorderStyle = BorderStyle.None;
                    DrawIcon(s);
                }
            }
        }

        private void PageForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Moved)
                    RollDice();
            }
        }

        private void RollDice()
        {
            Random random = new Random();
            x = random.Next(1, 7);
            pictureBox.Image?.Dispose();
            pictureBox.Image = null;
            pictureBox.Size = new Size(30, 30);
            pictureBox.Location = new Point(this.Width / 2 - 22, this.Height / 2 - 38);
            switch (x)
            {
                case 1:
                    pictureBox.Image = (Properties.Resources.Dice1);
                    break;
                case 2:
                    pictureBox.Image = (Properties.Resources.Dice2);
                    break;
                case 3:
                    pictureBox.Image = (Properties.Resources.Dice3);
                    break;
                case 4:
                    pictureBox.Image = (Properties.Resources.Dice4);
                    break;
                case 5:
                    pictureBox.Image = (Properties.Resources.Dice5);
                    break;
                case 6:
                    pictureBox.Image = (Properties.Resources.Dice6);
                    break;
                default:
                    break;
            }

            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pictureBox);
            if (MoveName[MoveNumber].StartsWith("B"))
            {
                foreach (PictureBox box in PointBlue.Keys)
                {
                    if (x == 6)
                        box.BorderStyle = BorderStyle.Fixed3D;
                    else if (!box.Location.Equals(PointBlue[box]))
                    {
                        box.BorderStyle = BorderStyle.Fixed3D;
                    }
                }
            }
            if (MoveName[MoveNumber].StartsWith("G"))
            {
                foreach (PictureBox box in PointGreen.Keys)
                {
                    if (x == 6)
                        box.BorderStyle = BorderStyle.Fixed3D;
                    else if (!box.Location.Equals(PointGreen[box]))
                    {
                        box.BorderStyle = BorderStyle.Fixed3D;
                    }
                }
            }
            if (MoveName[MoveNumber].StartsWith("R"))
            {
                foreach (PictureBox box in PointRed.Keys)
                {
                    if (x == 6)
                        box.BorderStyle = BorderStyle.Fixed3D;
                    else if (!box.Location.Equals(PointRed[box]))
                    {
                        box.BorderStyle = BorderStyle.Fixed3D;
                    }
                }
            }
            if (MoveName[MoveNumber].StartsWith("Y"))
            {
                foreach (PictureBox box in PointYellow.Keys)
                {
                    if (x == 6)
                        box.BorderStyle = BorderStyle.Fixed3D;
                    else if (!box.Location.Equals(PointYellow[box]))
                    {
                        box.BorderStyle = BorderStyle.Fixed3D;
                    }

                }
            }
            Moved = false;
            if (x != 6 && !FirstMove[MoveNumber])
            {
                Moved = true;
                MoveNumber += 1;
                MoveNumber %= 4;
                this.Text = "Move : " + MoveName[MoveNumber];
            }
        }

        private void MoveCoin(PictureBox pictureBox)
        {
            if (x == 6)
            {
                if (pictureBox.Name.StartsWith("B") && MoveName[MoveNumber].StartsWith("B"))
                {
                    if (pictureBox.Location.Equals(PointBlue[pictureBox]))
                    {
                        pictureBox.Location = new Point(810, 409);
                        x = 0;
                        Moved = true;
                        FirstMove[MoveNumber] = true;
                        AfterMove();
                        return;
                    }
                }
                if (pictureBox.Name.StartsWith("R") && MoveName[MoveNumber].StartsWith("R"))
                {
                    if (pictureBox.Location.Equals(PointRed[pictureBox]))
                    {
                        pictureBox.Location = new Point(389, 651);
                        x = 0;
                        Moved = true;
                        FirstMove[MoveNumber] = true;
                        AfterMove();
                        return;
                    }
                }
                if (pictureBox.Name.StartsWith("Y") && MoveName[MoveNumber].StartsWith("Y"))
                {
                    if (pictureBox.Location.Equals(PointYellow[pictureBox]))
                    {
                        pictureBox.Location = new Point(509, 71);
                        x = 0;
                        Moved = true;
                        FirstMove[MoveNumber] = true;
                        AfterMove();
                        return;
                    }
                }
                if (pictureBox.Name.StartsWith("G") && MoveName[MoveNumber].StartsWith("G"))
                {
                    if (pictureBox.Location.Equals(PointGreen[pictureBox]))
                    {
                        pictureBox.Location = new Point(90, 314);
                        x = 0;
                        Moved = true;
                        FirstMove[MoveNumber] = true;
                        AfterMove();
                        return;
                    }
                }
            }
            if (!Moved)
                for (int i = 0; i < x; i++)
                {
                    if (pictureBox.Name.StartsWith("R"))
                    {
                        pictureBox.Location = new Point(pictureBox.Location.X, pictureBox.Location.Y - 48);
                    }
                    else if (pictureBox.Name.StartsWith("G"))
                    {
                        pictureBox.Location = new Point(pictureBox.Location.X + 60, pictureBox.Location.Y);
                    }
                    else if (pictureBox.Name.StartsWith("B"))
                    {
                        pictureBox.Location = new Point(pictureBox.Location.X - 60, pictureBox.Location.Y);
                    }
                    else if (pictureBox.Name.StartsWith("Y"))
                    {
                        pictureBox.Location = new Point(pictureBox.Location.X, pictureBox.Location.Y + 48);
                    }

                    Moved = true;
                }
            if (x != 6 && Moved)
            {
                MoveNumber += 1;
                MoveNumber %= 4;
                this.Text = "Move : " + MoveName[MoveNumber];
            }
            if (Moved)
                AfterMove();
        }

        private void AfterMove()
        {
            foreach(var x in this.Controls)
            {
                if (x is PictureBox)
                {
                    ((PictureBox)x).BorderStyle = BorderStyle.None;
                }
            }

        }

        private void PageForm_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void PictureClick(object sender, EventArgs e)
        {
            MoveCoin(sender as PictureBox);
        }
    }
}
