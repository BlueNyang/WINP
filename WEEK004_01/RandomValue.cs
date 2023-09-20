using System;
using System.Windows.Forms;
using System.Drawing;

namespace WEEK04_01_1
{
    internal class RandomValue
    {
        Random rd = new Random();

        public void RandomLocation(Form form, Button btn)
        {
            btn.Location = new Point(rd.Next(form.ClientSize.Width-btn.Size.Width), rd.Next(form.ClientSize.Height-btn.Size.Height));
        }
        public void RandomRGBValue(RGBValue rgb)
        {
            rgb.r = rd.Next(0, 255);
            rgb.g = rd.Next(0, 255);
            rgb.b = rd.Next(0, 255);
        }
        public void RandomRGB(Button btn)
        {
            RGBValue rgb = new RGBValue();
            RandomRGBValue(rgb);
            btn.BackColor = Color.FromArgb(rgb.r, rgb.g, rgb.b);
            RandomRGBValue(rgb);
            btn.FlatAppearance.BorderColor = Color.FromArgb(rgb.r, rgb.g, rgb.b);

        }
        public void NewValue(Form form, Button btn)
        {
            RandomLocation(form, btn);
            RandomRGB(btn);
        }
        public RandomValue()
        {
        }
        public RandomValue(Form form, Button btn)
        {
            RandomLocation(form, btn);
            RandomRGB(btn);
        }
    }

    internal class RGBValue
    {
        internal int r, g, b;
        public RGBValue()
        {
            r = 255; g = 255; b = 255;
        }
        public RGBValue(int r, int g, int b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }
    }
}
