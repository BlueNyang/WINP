using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEEK11_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Paint += new PaintEventHandler(Painting);
            Resize += new EventHandler(FormResize);
        }

        private void FormResize(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Painting(object sender, PaintEventArgs e)
        {
            gradient();
        }
        private void painting()
        {
            Graphics g = CreateGraphics();

            SolidBrush b = new SolidBrush(Color.LightBlue);
            g.FillRectangle(b, ClientRectangle);
            b.Dispose();
        }

        private void wkulogo()
        {
            Graphics g = CreateGraphics();

            string filename = @"\원광대학교.jpg";
            if (!File.Exists(Environment.CurrentDirectory + filename))
                File.Copy($@"C:\Users\xpsj2\응애\4학기\Win{filename}", Environment.CurrentDirectory + filename);
            Image img = new Bitmap("원광대학교.jpg");
            TextureBrush b = new TextureBrush(img);
        }
        private void gradient()
        {
            Graphics g = CreateGraphics();
            List<Color> colors = new List<Color>()
            {
                Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Orchid, Color.Violet
            };
            int pointx = 0;
            LinearGradientBrush b;
            for (int i = 0; i< colors.Count - 1; i++) {
                b = new LinearGradientBrush(
                    new Point(pointx, 0), new Point(pointx + 100, 0),
                    colors[i], colors[i + 1]);
                g.FillRectangle(b, new Rectangle(pointx, 0, 100, 400));
                pointx += 100;
            }
        }

        private void gradient2()
        {
            Graphics g = CreateGraphics();

            Point[] pts = {
                new Point(ClientRectangle.Width / 2, 0),
                new Point(0, ClientRectangle.Height),
                new Point(ClientRectangle.Width, ClientRectangle.Height)
            };

            PathGradientBrush b = new PathGradientBrush(pts);
            ColorBlend cb = new ColorBlend();
            Color[] colors =
            {
                Color.Red, Color.Blue, Color.Green
            };
            b.SurroundColors = colors;
            b.CenterColor = Color.White
                ;
            g.FillRectangle(b, ClientRectangle);
            b.Dispose();
        }
        private void DrawLine()
        {
            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Black, 10);
            p.Width = 7;
            Point startPoint = new Point(45, 45);
            Point endPoint = new Point(180, 150);
            g.DrawLine(p, startPoint, endPoint);
            g.DrawLine(p, new Point(190, 60), new Point(65, 170));
            p.Dispose();
        }

        private void DrawLines()
        {
            Graphics g = CreateGraphics();

            Point[] pts =
            {
                new Point(40, 40),                new Point(180, 40),
                new Point(180, 180),                new Point(40, 180),
                new Point(40, 60),                new Point(160, 60),
                new Point(160, 160),                new Point(60, 160),
                new Point(60, 80),                new Point(140, 80),
                new Point(140, 140),                new Point(80, 140),
                new Point(80, 100),                new Point(120, 100),
                new Point(120, 120),                new Point(100, 120)
            };

            Pen p = new Pen(Color.Blue, 3);
            g.DrawLines(p, pts);
            g.Dispose();
        }

        private void DrawRectangle()
        {
            Graphics g = CreateGraphics();

            Rectangle r = new Rectangle(50, 50, 150, 100);
            g.FillRectangle(Brushes.Lime, r);
            g.DrawRectangle(new Pen(Color.Blue), r);

        }

        private void DrawRectangles()
        {
            Graphics g = CreateGraphics();

            Rectangle[] rects =
            {
                new Rectangle(40, 40, 40, 100),
                new Rectangle(100, 40, 100, 40),
                new Rectangle(100, 100, 100, 40)
            };
            g.FillRectangles(Brushes.Blue, rects);
            g.DrawRectangles(Pens.Red, rects);
        }
    }
}
