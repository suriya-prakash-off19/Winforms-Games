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
            this.rippleButton1.BackColor = System.Drawing.SystemColors.InfoText;
            this.rippleButton1.BorderColor = System.Drawing.Color.Blue;
            this.rippleButton1.BorderRadius = 30;
            this.rippleButton1.BorderSize = 3;
            this.rippleButton1.CausesValidation = false;
            this.rippleButton1.FlatAppearance.BorderSize = 0;
            this.rippleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rippleButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rippleButton1.ForeColor = System.Drawing.Color.Blue;
            this.rippleButton1.Location = new System.Drawing.Point(303, 342);
            this.rippleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rippleButton1.Name = "rippleButton1";
            this.rippleButton1.Ripple = true;
            this.rippleButton1.RippleColor = System.Drawing.Color.SandyBrown;
            this.rippleButton1.Size = new System.Drawing.Size(291, 73);
            this.rippleButton1.TabIndex = 0;
            this.rippleButton1.TabStop = false;
            this.rippleButton1.Text = "rippleButton1";
            this.rippleButton1.UseVisualStyleBackColor = false;
            this.rippleButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rippleButton1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rippleButton1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

