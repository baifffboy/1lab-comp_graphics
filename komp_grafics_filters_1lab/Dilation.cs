using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komp_grafics_filters_1lab
{
    internal class Dilation : MatrixFilters
    {
        public Dilation()
        {

            kernel = new float[,]
        {
         { 1.0f, 1.0f, 1.0f},
         { 1.0f, 1.0f, 1.0f},
         { 1.0f, 1.0f, 1.0f},
         {1.0f, 1.0f, 1.0f},
         {1.0f, 1.0f, 1.0f}
        };
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            Color maxColor = Color.Black;
            Color OrCol = sourceImage.GetPixel(x, y);
            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int newX = x + k;
                    int newY = y + l;
                    if (newX >= 0 && newX < sourceImage.Width && newY >= 0 && newY < sourceImage.Height)
                    {
                        Color neighborCol = sourceImage.GetPixel(newX, newY);
                        if (neighborCol.GetBrightness() > maxColor.GetBrightness())
                        {
                            maxColor = neighborCol;
                        }
                    }
                }
            }
            return maxColor;
        }
    }
}
