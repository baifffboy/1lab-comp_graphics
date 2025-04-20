using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komp_grafics_filters_1lab
{
    internal class HorizontalWaves : Filters
    {
        private double amplitude; 
        private double frequency;
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int k, int l)
        {
            amplitude = 20;
            frequency = 60;
            int x = k; 
            int y = Clamp(l + (int)(amplitude * Math.Sin(2 * Math.PI * k / frequency)), 0, sourceImage.Height - 1);
            if (x >= 0 && x < sourceImage.Width && y >= 0 && y < sourceImage.Height)
            {
                return sourceImage.GetPixel(x, y);
            }
            else
            {
                return Color.FromArgb(255, 0, 0, 0);
            }
        }
    }
}
