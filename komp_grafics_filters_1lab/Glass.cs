using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komp_grafics_filters_1lab
{
    internal class Glass : MatrixFilters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int k, int l)
        {
            Random random = new Random();
            int x = k + random.Next(-5,5);
            int y = l + random.Next(-5,5);
            if (x >= 0 && x < sourceImage.Width && y >= 0 && y < sourceImage.Height)
            {
                return sourceImage.GetPixel(Clamp(x, 0, sourceImage.Width), Clamp(y, 0, sourceImage.Height));
            }
            else
            {
                return Color.FromArgb(255, 0, 0, 0);
            }
        }
    }
}
