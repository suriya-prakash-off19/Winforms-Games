namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Obstacle3 = new System.Windows.Forms.PictureBox();
            this.Obstacle2 = new System.Windows.Forms.PictureBox();
            this.Obstacle1 = new System.Windows.Forms.PictureBox();
            this.Dino = new System.Windows.Forms.PictureBox();
            this.lblHighScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ScoreLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(0, 0);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(167, 45);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "Score : 0";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 15;
            this.Timer.Tick += new System.EventHandler(this.GameTimer);
            // 
            // Obstacle3
            // 
            this.Obstacle3.Image = global::WindowsFormsApp1.Properties.Resources.flying;
            this.Obstacle3.Location = new System.Drawing.Point(729, 395);
            this.Obstacle3.Margin = new System.Windows.Forms.Padding(4);
            this.Obstacle3.Name = "Obstacle3";
            this.Obstacle3.Size = new System.Drawing.Size(89, 58);
            this.Obstacle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Obstacle3.TabIndex = 5;
            this.Obstacle3.TabStop = false;
            this.Obstacle3.Tag = "Obstacles";
            // 
            // Obstacle2
            // 
            this.Obstacle2.Image = global::WindowsFormsApp1.Properties.Resources.cactus2;
            this.Obstacle2.Location = new System.Drawing.Point(455, 384);
            this.Obstacle2.Margin = new System.Windows.Forms.Padding(4);
            this.Obstacle2.Name = "Obstacle2";
            this.Obstacle2.Size = new System.Drawing.Size(77, 111);
            this.Obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Obstacle2.TabIndex = 4;
            this.Obstacle2.TabStop = false;
            this.Obstacle2.Tag = "Obstacles";
            // 
            // Obstacle1
            // 
            this.Obstacle1.Image = global::WindowsFormsApp1.Properties.Resources.cactus1;
            this.Obstacle1.Location = new System.Drawing.Point(388, 384);
            this.Obstacle1.Margin = new System.Windows.Forms.Padding(4);
            this.Obstacle1.Name = "Obstacle1";
            this.Obstacle1.Size = new System.Drawing.Size(59, 111);
            this.Obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Obstacle1.TabIndex = 3;
            this.Obstacle1.TabStop = false;
            this.Obstacle1.Tag = "Obstacles";
            this.Obstacle1.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Dino
            // 
            this.Dino.Image = global::WindowsFormsApp1.Properties.Resources.dino_run;
            this.Dino.Location = new System.Drawing.Point(263, 382);
            this.Dino.Margin = new System.Windows.Forms.Padding(4);
            this.Dino.Name = "Dino";
            this.Dino.Size = new System.Drawing.Size(88, 92);
            this.Dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dino.TabIndex = 2;
            this.Dino.TabStop = false;
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHighScore.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(949, 0);
            this.lblHighScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(260, 45);
            this.lblHighScore.TabIndex = 6;
            this.lblHighScore.Text = "High Score : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1209, 544);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.Dino);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.Obstacle1);
            this.Controls.Add(this.Obstacle2);
            this.Controls.Add(this.Obstacle3);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dino Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPaint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.PictureBox Dino;
        private System.Windows.Forms.PictureBox Obstacle1;
        private System.Windows.Forms.PictureBox Obstacle2;
        private System.Windows.Forms.PictureBox Obstacle3;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label lblHighScore;
    }
}

