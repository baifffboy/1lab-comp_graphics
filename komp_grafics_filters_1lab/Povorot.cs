using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komp_grafics_filters_1lab
{
    internal class Povorot : MatrixFilters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int k, int l)
        {
            int x0 = sourceImage.Width;
            int y0 = sourceImage.Height;
            double q = 15 * Math.PI / 180.0; ;
            int x = (int)((k - x0) * Math.Cos(q) - (l - y0) * Math.Sin(q) + x0);
            int y = (int)((k - x0) * Math.Sin(q) + (l - y0) * Math.Cos(q) + y0);
            if (x >= 0 && x < sourceImage.Width && y >= 0 && y < sourceImage.Height)
            {
                  return sourceImage.GetPixel(x, y);
            }
            else
            {
                return Color.FromArgb(255, 0, 0, 0); //черный
            }               
        }
    }
}
