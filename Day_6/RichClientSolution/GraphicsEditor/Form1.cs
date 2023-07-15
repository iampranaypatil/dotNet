using System.Drawing;

namespace GraphicsEditor
{
    public partial class Form1 : Form
    {
        Point startPoint = new Point(34, 300);
        Point endPoint = new Point(200, 400);
        public Form1()
        {
            InitializeComponent();
        }

        private void OnFileExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnFileOpen(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd.FileName;
                this.Text = fileName;

            }
        }

        private void OnLogin(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            if (formLogin.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void OnShapeLine(object sender, EventArgs e)
        {
           

        }

        private void OnFormMouseDown(object sender, MouseEventArgs e)
        {

          startPoint = new Point(e.X,e.Y);
        }

        private void OnFormMouseUp(object sender, MouseEventArgs e)
        {
            endPoint = new Point(e.X, e.Y);
            Pen thePen = new Pen(Color.Blue, 3);
            Graphics g = this.CreateGraphics();
            g.DrawLine(thePen, startPoint, endPoint);
        }
    }
}