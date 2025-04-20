using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komp_grafics_filters_1lab
{
    internal class proverka : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);

            byte red = sourceColor.R;
            byte green = sourceColor.G;
            byte blue = sourceColor.B;
            double alpha = 0.36 * sourceColor.R + 0.53 * sourceColor.G + 0.11 * sourceColor.B;

            if ((0 <= alpha) && (alpha <= 64)) return Color.FromArgb(0, 0, 0);
            if ((65 <= alpha) && (alpha <= 128)) return Color.FromArgb(128, 128, 0);
            if ((129 <= alpha) && (alpha <= 192)) return Color.FromArgb(255, 255, 0);
            if ((193 <= alpha) && (alpha <= 255)) return Color.FromArgb(255, 255, 255);
            else return Color.FromArgb(0, 0, 0);
        }
    }
}