using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ManageEmployee : Form
    {
        public ManageEmployee(Form1 form)
        {
            InitializeComponent();
            nameChange();
        }
        private async Task nameChange()
        {
            await Task.Delay(10000);
            label2.Text = "hello";

        }
        private void setName(string name)
        {
            label1.Text = name;
        }
        private void setval1(string name)
        {
            label2.Text = name;
        }
        private void setval2(string name)
        {
            label3.Text = name;
        }
        private void setval3(string name)
        {
            label4.Text = name;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
