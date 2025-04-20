using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komp_grafics_filters_1lab
{
    internal class VerticalWaves : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int k, int l)
        {
            int x = (int)(k + 20 * Math.Sin(2 * Math.PI * l / 60));
            int y = l;
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
