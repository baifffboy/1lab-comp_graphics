using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komp_grafics_filters_1lab
{
    internal class Perenos : MatrixFilters
    {

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int newX = x + 50;
            int newY = y;
            if (newX >= 0 && newX < sourceImage.Width && newY >= 0 && newY < sourceImage.Height)
            {
                return sourceImage.GetPixel(newX, newY);
            }
            else
            {
                return Color.FromArgb(255, 0, 0, 0);
            }
        }
    }
}
