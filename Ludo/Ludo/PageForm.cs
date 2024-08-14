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
        public PageForm()
        {
            InitializeComponent();

        }

        private void DrawIcon(object s)
        {
            PictureBox pictureBox = s as PictureBox;
            Color c = pictureBox.BackColor;
            if (pictureBox.Name.StartsWith("R"))
            {
                c = Color.DarkRed;
            }
            else if (pictureBox.Name.StartsWith("B"))
            {
                c = Color.DarkSlateBlue;
            }
            else if (pictureBox.Name.StartsWith("G"))
            {
                c = Color.GreenYellow;
            }
            else if (pictureBox.Name.StartsWith("Y"))
            {
                c = Color.YellowGreen;
            }

            Bitmap bitmap = new Bitmap(100,100);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode=System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Brush brush = new SolidBrush(c);
                g.Clear(Color.Transparent);
                g.FillEllipse(brush,5,5,90,90);
            }
            pictureBox.Image = bitmap;

        }

        private void PageForm_MouseDown(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(e.X + " " + e.Y);
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
                    DrawIcon(s);
                }
            }
        }
    }
}
