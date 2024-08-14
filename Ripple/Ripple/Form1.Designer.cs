namespace Ripple
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
            this.rippleButton1 = new Ripple.RippleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rippleButton1
            // 
            this.rippleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rippleButton1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rippleButton1.BorderColor = System.Drawing.Color.Black;
            this.rippleButton1.BorderRadius = 30;
            this.rippleButton1.BorderSize = 0;
            this.rippleButton1.CausesValidation = false;
            this.rippleButton1.FlatAppearance.BorderSize = 0;
            this.rippleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rippleButton1.ForeColor = System.Drawing.Color.BlueViolet;
            this.rippleButton1.Location = new System.Drawing.Point(227, 278);
            this.rippleButton1.Name = "rippleButton1";
            this.rippleButton1.Ripple = false;
            this.rippleButton1.RippleColor = System.Drawing.Color.Tomato;
            this.rippleButton1.Size = new System.Drawing.Size(249, 115);
            this.rippleButton1.TabIndex = 0;
            this.rippleButton1.TabStop = false;
            this.rippleButton1.Text = "rippleButton1";
            this.rippleButton1.UseVisualStyleBackColor = false;
            this.rippleButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rippleButton1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rippleButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RippleButton rippleButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

