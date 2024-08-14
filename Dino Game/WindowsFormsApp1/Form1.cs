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
using System.Drawing.Text;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool DinoUp, DinoDown, GameOver, FlyingAttack, ChangeAnim;
        int Score = 0;
        int FormWidth;
        int CactusSpeed = 12;
        int AttackTimer = 0;
        int AttackR = 0;
        int Speed = 10;
        int HighScore=0;
        int[] FlyingPosition = { 285, 350, 285, 350, 285, 350, 285, 350, 285, 350, 285, 350 };

        bool Changed = false;
        bool Run = false;
        Random random = new Random();
        List<PictureBox> Obstaclus = new List<PictureBox>();
        PictureBox HitBox = new PictureBox();
        SoundPlayer PlayerHit;
        SoundPlayer Point;

        public Form1()
        {
            DinoUp = DinoDown = GameOver = FlyingAttack = ChangeAnim = false;
            InitializeComponent();
            GameSetUp();
            Reset();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (Dino.Top == 313)
                DinoUp = DinoDown = false;
            if(ChangeAnim)
            {
                ChangeAnim = false;
                Dino.Image = Properties.Resources.dino_run;
                Dino.Top -= 40;
            }
        }

        private void FormPaint(object sender, PaintEventArgs e)
        {

        }

        private void GameTimer(object sender, EventArgs e)
        {
            HitBox.Left = Dino.Left + 25;
            HitBox.Top = Dino.Top + 5;
            if (DinoUp)
            {
                Dino.Top -= Speed;
                if (Dino.Top < 170)
                {
                    Speed = -10;
                }
                if (Dino.Top > 312)
                {
                    Dino.Top = 313;
                    DinoUp = false;
                    Speed = 10;
                }
            }
            ScoreLabel.Text = "Score : " + Score.ToString();
            if(Run)
            SetObstacles();
            if (Score % 20 == 0 && Score != 0)
            {
                BackColor = Color.White;
                ScoreLabel.ForeColor = Color.Black;
                lblHighScore.ForeColor = Color.Black;
            }

            if (Score % 40 == 0 && Score != 0)
            {
                BackColor = Color.Black;
                ScoreLabel.ForeColor = Color.White;
                lblHighScore.ForeColor = Color.White;
            }
            //if (!DinoDown)
            //    Dino.Image = Properties.Resources.dino_run;
            //else
            //    Dino.Image = Properties.Resources.dino_crouch;
            foreach(PictureBox x in Obstaclus)
            {
                if(x.Bounds.IntersectsWith(HitBox.Bounds))
                {
                    Timer.Stop();
                    GameOver = true;
                    Dino.Image = Properties.Resources.dead;
                    PlayerHit = new SoundPlayer(Properties.Resources.hit);
                    PlayerHit.Play();
                }
            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!GameOver)
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Space)
                {
                    if(Run)
                    DinoUp = true;
                    else
                    {
                        Timer.Start();
                        Run = true;
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    DinoDown = true;
                    if(!ChangeAnim)
                    {
                        Dino.Image = Properties.Resources.dino_crouch;
                        ChangeAnim = true;
                        Dino.Top += 40;
                    }
                }

            }
            else
            {
                HighScore = Math.Max(HighScore, Score);
                lblHighScore.Text = "High Score : " + HighScore;
                GameSetUp();
                Reset();
                Timer.Start();
            }
            
        }

        private void Reset()
        {
            Dino.Image = Properties.Resources.dino_run;
            Dino.Top = 313;

            Obstacle1.Left = FormWidth + random.Next(200, 400);
            Obstacle2.Left = FormWidth + random.Next(1000, 1200);
            Obstacle3.Left = FormWidth + 1100;
            
            Score = 0;
            ScoreLabel.Text = "Score : 0";
            GameOver = false;
            ChangeAnim = false;
            FlyingAttack = false;
            Speed = 10;
            CactusSpeed = 12;
            DinoUp = false;
            Changed = false;
            AttackTimer = 0;
        }

        private void GameSetUp()
        {
            DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            FormWidth = ClientSize.Width;
            BackColor = Color.Black;
            Obstacle1.Top = Obstacle2.Top = Obstacle3.Top = 313 + 10;
            Obstaclus.Add(Obstacle1);
            Obstaclus.Add(Obstacle2);
            Obstaclus.Add(Obstacle3);
            ScoreLabel.ForeColor = Color.White;
            lblHighScore.ForeColor = Color.White;
            HitBox.BackColor = Color.Transparent;
            HitBox.Height = Dino.Height - 22;
            HitBox.Width = Dino.Width / 2-10;
            HitBox.Enabled = true;
            this.Controls.Add(HitBox);
            GameOver = false;
            AttackR = random.Next(12, 20);
            HitBox.Left = Dino.Left+20;
            HitBox.Top = Dino.Top + 5;
            //HitBox.BringToFront();
        }

        private void SetObstacles()
        {
            Point = new SoundPlayer(Properties.Resources.plusone);
            if (!FlyingAttack)
            {
                Obstacle1.Left -= CactusSpeed;
                Obstacle2.Left -= CactusSpeed;
            }
            else
            {
                Obstacle3.Left -= CactusSpeed;
            }
            if (AttackTimer == AttackR)
            {
                FlyingAttack = true;
                AttackR = random.Next(12, 20);
            }
            if (AttackTimer < 0)
            {
                FlyingAttack = false;
            }
            if (Obstacle1.Left < -100)
            {
                Obstacle1.Left = 100 + Obstacle2.Left + FormWidth + random.Next(100, 400);
                AttackTimer += 1;
                Score += 1;
                Changed = false;
                Point.Play();
            }
            if (Obstacle2.Left < -100)
            {
                Obstacle2.Left = 100 + Obstacle1.Left + FormWidth + random.Next(100, 400);
                AttackTimer += 1;
                Score += 1;
                Changed = false;
                Point.Play();
            }
            if (Obstacle3.Left < -100)
            {
                AttackTimer -= 2;
                Obstacle3.Left = FormWidth + random.Next(200, 400);
                Obstacle3.Top = FlyingPosition[random.Next(FlyingPosition.Length)];
                Score += 1;
                Changed = false;
                Point.Play();
            }
            if(Score%30==0 && !Changed)
            {
                Changed = true;
                CactusSpeed += 1;
            }

        }

        private void MoveBackGround()
        {

        }

    }
}
