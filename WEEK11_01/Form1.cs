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

        Graphics g;
        public Form1()
        {
            InitializeComponent();
            Paint += new PaintEventHandler(Painting);
            Resize += new EventHandler(FormResize);
            g = CreateGraphics();
        }

        private void FormResize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Painting(object sender, PaintEventArgs e)
        {
            DrawRainbowStar();
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
            string filename = @"\원광대로고.png";
            if (!File.Exists(Environment.CurrentDirectory + filename))
                File.Copy($@"C:\Users\xpsj2\응애\4학기\Win{filename}", Environment.CurrentDirectory + filename);
            Image img = new Bitmap("원광대로고.png");
            TextureBrush b = new TextureBrush(img);
            g.FillRectangle(b, ClientRectangle);
            img.Dispose();
            b.Dispose();
        }
        private void gradient()
        {
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
            Point[] pts = {
                new Point(ClientRectangle.Width / 2, 0),
                new Point(0, ClientRectangle.Height),
                new Point(ClientRectangle.Width, ClientRectangle.Height)
            };

            PathGradientBrush b = new PathGradientBrush(pts);
            Color[] colors =
            {
                Color.Red, Color.Blue, Color.Green
            };

            b.SurroundColors = colors;
            b.CenterColor = Color.White;

            g.FillRectangle(b, ClientRectangle);
            b.Dispose();
        }
        private void DrawLine()
        {
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
            Rectangle r = new Rectangle(50, 50, 150, 100);
            g.FillRectangle(Brushes.Lime, r);
            g.DrawRectangle(new Pen(Color.Blue), r);

        }

        private void DrawRectangles()
        {
            Rectangle[] rects =
            {
                new Rectangle(40, 40, 40, 100),
                new Rectangle(100, 40, 100, 40),
                new Rectangle(100, 100, 100, 40)
            };
            g.FillRectangles(Brushes.Blue, rects);
            g.DrawRectangles(Pens.Red, rects);
        }

        private void DrawingEllipse()
        {
            Rectangle r = new Rectangle(50, 50, 150, 100);
            g.FillEllipse(Brushes.Cyan, r);
            g.DrawEllipse(Pens.Black, r);
        }

        private void DrawArc()
        {
            Rectangle r = new Rectangle(50, 50, 150, 100);
            g.DrawArc(Pens.Red, r, 45, 270);
        }

        private void DrawPie()
        {
            Rectangle r = new Rectangle(50, 50, 150, 100);
            g.FillPie(Brushes.LightGreen, r, 45, 270);
            g.DrawPie(Pens.DarkGreen, r, 45, 270);
        }
        private void DrawRainbowPizza()
        {
            Rectangle r = new Rectangle(100, 100, 100, 100);
            int degree = 360;
            Color[] color = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Purple };
            for(int i =0; i<7; i++)
            {
                g.FillPie(new SolidBrush(color[i]), r, degree, -(360 / 8));
                g.DrawPie(Pens.Black, r, degree, -(360 / 8));
                degree -= 45;
            }
        }

        private void DrawStar()
        {
            Point[] pts =
            {
                new Point(110,40), new Point(125,91),
                new Point(180, 91), new Point(135,123),
                new Point(152,172), new Point(110,141),
                new Point(66,172), new Point(82,122),
                new Point(40,91), new Point(95,91)
            };
            g.FillPolygon(Brushes.Pink, pts);
            g.DrawPolygon(Pens.Purple, pts);
        }

        private void DrawRainbowStar()
        {
            Point[] pts =
            {
                new Point(110,40), new Point(125,91),
                new Point(180, 91), new Point(135,123),
                new Point(152,172), new Point(110,141),
                new Point(66,172), new Point(82,122),
                new Point(40,91), new Point(95,91)
            };
            Point Center = new Point(0, 0);
            for (int i = 0; i < pts.Length/2; i++)
            {
                Center.X += pts[i*2].X;
                Center.Y += pts[i*2].Y;
            }
            Center.X = Center.X / (pts.Length/2);
            Center.Y = Center.Y / (pts.Length/2);
            Color[] Colors = { Color.Red, Color.Yellow, Color.Green, Color.Blue, Color.Purple };
            int index = 0;

            for(int i = 0; i < 5; i++)
            {
                Point[] temp = { pts[index], pts[(index + 1) % pts.Length], pts[(index + 2) % pts.Length], Center };
                g.FillPolygon(new SolidBrush(Colors[i]), temp);
                g.DrawPolygon(Pens.Black, temp);
                index += 2;
            }
        }

        private void DrawCurves()
        {
            Point[] point = { new Point(40, 100), new Point(50, 60), new Point(60, 50), new Point(70, 60),
new Point(80, 100), new Point(90, 140), new Point(100, 150), new Point(110, 140),
new Point(120, 100), new Point(130, 60), new Point(140, 50), new Point(150, 60),
new Point(160, 100), new Point(170, 140), new Point(180, 150), new Point(190, 140),
new Point(200, 100)};

            g.DrawCurve(Pens.Red, point);
        }

        private void DrawClosedCurve()
        {
            Point[] pts = {
new Point(115, 30), new Point(140, 90),
new Point(200, 115), new Point(140, 140),
new Point(115, 200), new Point(90, 140),
new Point(30, 115), new Point(90, 90)
};
            g.FillClosedCurve(Brushes.Yellow, pts);
            g.DrawClosedCurve(Pens.Red, pts);
        }

        private void DrawBezier()
        {
            g.DrawBezier(Pens.Magenta, new Point(100, 50), new Point(0, 100), new Point(200, 100), new Point(100, 150));
        }

        private void DrawBezierCurve()
        {
            Point[] pts = {
                new Point(30, 30),
                new Point(60, 30),new Point(30, 60),
                new Point(60, 60),
                new Point(90, 60), new Point(60, 90),
                new Point(90, 90),
                new Point(120, 90), new Point(90, 120),
                new Point(120, 120),
                new Point(150, 120), new Point(120, 150),
                new Point(150, 150)};
            g.DrawBeziers(Pens.DeepPink, pts);
        }

        private void DrawString1()
        {
            string s = "Hello World";
            Font f = new Font("Tahoma", 15);
            g.DrawString(s, f, Brushes.Black, 10, 10);
            f.Dispose();
        }

        private void DrawString2()
        {
            string s = "This string is long enough to wrap.";
            s += " With a 250pxwidth rectangle, ";
            s += "it requires six lines to display the string in its entirety.";
            Font f = new Font("Tahoma", 15);
            Rectangle r = new Rectangle(10, 10, 250, 150);
            g.DrawRectangle(Pens.Black, r);
            g.DrawString(s, f, Brushes.Black, r);
            f.Dispose();
        }

        private void DrawString3()
        {

        }


    }
}
