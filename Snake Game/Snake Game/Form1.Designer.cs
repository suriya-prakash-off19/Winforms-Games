namespace Snake_Game
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
            this.SnakeBox = new System.Windows.Forms.PictureBox();
            this.Runner = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SnakeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SnakeBox
            // 
            this.SnakeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SnakeBox.Location = new System.Drawing.Point(0, 0);
            this.SnakeBox.Margin = new System.Windows.Forms.Padding(4);
            this.SnakeBox.Name = "SnakeBox";
            this.SnakeBox.Size = new System.Drawing.Size(800, 738);
            this.SnakeBox.TabIndex = 0;
            this.SnakeBox.TabStop = false;
            // 
            // Runner
            // 
            this.Runner.Enabled = true;
            this.Runner.Interval = 200;
            this.Runner.Tick += new System.EventHandler(this.Runner_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 738);
            this.Controls.Add(this.SnakeBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1118, 1085);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveSetter);
            ((System.ComponentModel.ISupportInitialize)(this.SnakeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SnakeBox;
        private System.Windows.Forms.Timer Runner;
    }
}

