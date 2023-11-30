using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace WEEK11_01
{
    public partial class Form1 : Form
    {
        Graphics g;
        private readonly string filename = @"원광대로고.png";

        public Form1()
        {
            InitializeComponent();

            //로고 이미지 파일 확인
            string cd = Environment.CurrentDirectory;
            DirectoryInfo proj_path = new DirectoryInfo(Path.Combine(cd, $@"..\..\.."));
            if (!File.Exists(Path.Combine(cd, filename)))
                File.Copy(Path.Combine(proj_path.FullName, filename), Path.Combine(cd, filename));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Resize += new EventHandler(FormResize);
            Paint += new PaintEventHandler(Painting);
            g = CreateGraphics();
        }

        private void FormResize(object sender, EventArgs e)
        {
            g = CreateGraphics();
            Invalidate();
        }

        private void Painting(object sender, PaintEventArgs e)
        {
            DrawImage3();
        }

        private void painting()
        {
            SolidBrush b = new SolidBrush(Color.LightBlue);
            g.FillRectangle(b, ClientRectangle);
            b.Dispose();
        }

        private void wkulogo()
        {
            Image img = new Bitmap(filename);
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
            Rectangle r = new Rectangle(10, 10, ClientSize.Width - 30, ClientSize.Height - 30);
            g.DrawString(s, f, Brushes.Black, r);
            g.DrawRectangle(Pens.Black, r);
            f.Dispose();
        }

        private void DrawString3()
        {
            string s = "This is a long string that will wrap";
            s += "It will be centered both vertically and horizontally";
            Font f = new Font("Tahoma", 15);

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            g.DrawString(s, f, Brushes.Black, ClientRectangle, sf);
            f.Dispose();
        }

        private void MeasureString()
        {
            string s = "Hello World!";
            Font f = new Font("Tahoma", 15);
            SizeF sf = g.MeasureString(s, f);
            g.DrawString(s, f, Brushes.Black, (ClientRectangle.Width - sf.Width) / 2, (ClientRectangle.Height - sf.Height) / 2);
            g.DrawRectangle(Pens.Black, (ClientRectangle.Width - sf.Width) / 2, (ClientRectangle.Height - sf.Height) / 2, sf.Width, sf.Height);
        }

        private void MeasureString2()
        {
            string s = "This is long enough to wrap";
            s += "We'll use a 15pt font, and assume";
            s += "the text string must fit into a width of 250 pixels.";

            Font f = new Font("Tahoma", 15);
            SizeF sf = g.MeasureString(s, f, 250);
            RectangleF rf = new RectangleF(20, 20, sf.Width, sf.Height);
            Rectangle r = Rectangle.Ceiling(rf);

            g.DrawString(s, f, Brushes.Black, rf);
            g.DrawRectangle(Pens.Black, r);

            f.Dispose();
        }

        private void DrawImage()
        {
            Image img = new Bitmap(filename);
            g.DrawImage(img, 0, 0);
            //g.DrawImage(img, ClientRectangle);
        }

        private void DrawImage2()
        {
            Image img = new Bitmap(filename);
            Point[] pts1 = { new Point(0, 0), new Point(200, 0), new Point(50, 100) };
            Point[] pts2 = { new Point(0, 100), new Point(200, 100), new Point(0, 0) };
            Point[] pts3 = { new Point(100, 0), new Point(100, 200), new Point(0, 0) };

            g.DrawImage(img, pts3);
        }

        private void DrawImage3()
        {
            Image img = new Bitmap(filename);

            Rectangle partial_source_rect = new Rectangle(0, 0, 80, 30);
            Rectangle draw_rect = new Rectangle(0, 0, 200, 100);

            g.DrawImage(img, draw_rect, partial_source_rect, GraphicsUnit.Pixel);
        }
    }
}
