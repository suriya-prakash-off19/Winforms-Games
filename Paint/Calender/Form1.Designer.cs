namespace Calender
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ColorCarry = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.ColorCarry);
            this.panel1.Controls.Add(this.btnUndo);
            this.panel1.Controls.Add(this.btnRedo);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 91);
            this.panel1.TabIndex = 0;
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ForeColor = System.Drawing.Color.White;
            this.btnUndo.Location = new System.Drawing.Point(52, 9);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(66, 31);
            this.btnUndo.TabIndex = 6;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedo.ForeColor = System.Drawing.Color.White;
            this.btnRedo.Location = new System.Drawing.Point(124, 9);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(66, 31);
            this.btnRedo.TabIndex = 5;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = false;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(941, 15);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 53);
            this.button6.TabIndex = 3;
            this.button6.Text = "Line";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(16, 8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 53);
            this.button5.TabIndex = 4;
            this.button5.Text = "Pen";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(797, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 53);
            this.button4.TabIndex = 3;
            this.button4.Text = "Erase";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(869, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "Box";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1013, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Circle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1085, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1206, 602);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // ColorCarry
            // 
            this.ColorCarry.BackColor = System.Drawing.Color.Red;
            this.ColorCarry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorCarry.Location = new System.Drawing.Point(563, 34);
            this.ColorCarry.Name = "ColorCarry";
            this.ColorCarry.Size = new System.Drawing.Size(54, 34);
            this.ColorCarry.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Location = new System.Drawing.Point(636, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(542, 82);
            this.panel3.TabIndex = 8;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(88, 8);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(66, 53);
            this.button7.TabIndex = 5;
            this.button7.Text = "Color";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 693);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Panel ColorCarry;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button7;
    }
}

