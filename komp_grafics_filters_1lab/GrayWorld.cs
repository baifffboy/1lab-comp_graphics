using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komp_grafics_filters_1lab
{
    internal class GrayWorld : Filters
    {
        private double[] avg;

        public void CalculateAverageBrightness(Bitmap sourceIm)
        {
            long totalR = 0;
            long totalG = 0;
            long totalB = 0;
            int pixelCount = sourceIm.Width * sourceIm.Height;

            for (int y = 0; y < sourceIm.Height; y++)
            {
                for (int x = 0; x < sourceIm.Width; x++)
                {
                    Color pixelColor = sourceIm.GetPixel(x, y);
                    totalR += pixelColor.R;
                    totalG += pixelColor.G;
                    totalB += pixelColor.B;
                }
            }

            double averageR = totalR / (double)pixelCount;
            double averageG = totalG / (double)pixelCount;
            double averageB = totalB / (double)pixelCount;
            avg = new double[] { averageR, averageG, averageB };
        }

        protected override Color calculateNewPixelColor(Bitmap sourceIm, int x, int y)
        {
            if (avg == null)
            {
                CalculateAverageBrightness(sourceIm);
            }
            Color OrColor = sourceIm.GetPixel(x, y);
            double avgc = (avg[0] + avg[1] + avg[2]) / 3;
            double R = OrColor.R * (avgc / avg[0]);
            double G = OrColor.G * (avgc / avg[1]);
            double B = OrColor.B * (avgc / avg[2]);

            return Color.FromArgb(
                Clamp((int)R, 0, 255),
                Clamp((int)G, 0, 255),
                Clamp((int)B, 0, 255));
        }
    }
}
