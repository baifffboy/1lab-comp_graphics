using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komp_grafics_filters_1lab
{
    internal class AutoContrast : Filters
    {
        private int minR = 255, minG = 255, minB = 255;
        private int maxR = 0, maxG = 0, maxB = 0;

        private void CalculateMinMax(Bitmap sourceIm)
        {
            for (int y = 0; y < sourceIm.Height; y++)
            {
                for (int x = 0; x < sourceIm.Width; x++)
                {
                    Color pixelColor = sourceIm.GetPixel(x, y);
                    if (pixelColor.R < minR) minR = pixelColor.R;
                    if (pixelColor.G < minG) minG = pixelColor.G;
                    if (pixelColor.B < minB) minB = pixelColor.B;
                    if (pixelColor.R > maxR) maxR = pixelColor.R;
                    if (pixelColor.G > maxG) maxG = pixelColor.G;
                    if (pixelColor.B > maxB) maxB = pixelColor.B;
                }
            }
        }

        protected override Color calculateNewPixelColor(Bitmap sourceIm, int x, int y)
        {
            if (minR == 255 && maxR == 0)
            {
                CalculateMinMax(sourceIm);
            }
            Color OrColor = sourceIm.GetPixel(x, y);
            int R = (OrColor.R - minR) * 255 / (maxR - minR);
            int G = (OrColor.G - minG) * 255 / (maxG - minG);
            int B = (OrColor.B - minB) * 255 / (maxB - minB);

            return Color.FromArgb(
                Clamp(R, 0, 255),
                Clamp(G, 0, 255),
                Clamp(B, 0, 255));
        }
    }
}

