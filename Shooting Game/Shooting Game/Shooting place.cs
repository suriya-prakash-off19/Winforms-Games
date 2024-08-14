using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shooting_Game
{
    public partial class Shooting_place : Form
    {
        public Shooting_place()
        {
            InitializeComponent();
        }

        private void Shooting_place_KeyDown(object sender, KeyEventArgs e)
        {
            var key = e.KeyCode;
            if (key == Keys.Left)
            {
                Move(-10);
            }
            else if (key == Keys.Right) {
                Move(10);
             }
        }

        private void Move(int v)
        {
            pictureBox1.Left += v;
        }
    }
}
