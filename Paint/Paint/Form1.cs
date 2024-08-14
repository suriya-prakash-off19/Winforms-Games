
namespace Paint
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        int width;
        public Form1()
        {
            InitializeComponent();
            bitmap=new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;
            width = 30;
            DrawSquare();
        }

        private void DrawSquare()
        {
            int i, j;
            for(i=1;i<pictureBox1.Width;i+=width)
            {
                for(j=1;j<pictureBox1.Height;j+=width)
                {
                    graphics.DrawRectangle(new Pen(Color.Black), i,j, width, width);
                }
            }
        }
    }
}
