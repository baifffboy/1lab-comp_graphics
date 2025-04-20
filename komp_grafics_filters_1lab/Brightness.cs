using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komp_grafics_filters_1lab
{
    internal class Brightness : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            double k = 14.0;
            double R = sourceColor.R + k;
            double G = sourceColor.G + k;
            double B = sourceColor.B + k;
            Color resultColor = Color.FromArgb(Clamp((int)R, 0, 255), Clamp((int)G, 0, 255), Clamp((int)B, 0, 255));
            return resultColor;
        }
    }
}
