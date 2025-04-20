using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komp_grafics_filters_1lab
{
    internal class Embossing : MatrixFilters
    {
        private static readonly float[,] kernels = new float[,]
        {
            { 0, 1, 0 },
            { 1, 0, -1 },
            { 0, -1, 0 }
        };

        private int brightnessShift;


        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            //Color baseColor = base.calculateNewPixelColor(sourceImage, x, y);

            int radiusX = kernels.GetLength(0) / 2;
            int radiusY = kernels.GetLength(1) / 2;
            float resultR = 0;
            float resultG = 0;
            float resultB = 0;
            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1); // Clamp используется не по прямому назначению, а чтобы не выйти за размер картинки
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    resultR += neighborColor.R * kernels[k + radiusX, l + radiusY];
                    resultG += neighborColor.G * kernels[k + radiusX, l + radiusY];
                    resultB += neighborColor.B * kernels[k + radiusX, l + radiusY];
                }
            }

            resultR += brightnessShift;
            resultG += brightnessShift;
            resultB += brightnessShift;

            return Color.FromArgb(Clamp((int)resultR, 0, 255), Clamp((int)resultG, 0, 255), Clamp((int)resultB, 0, 255));
        }

        public Embossing(int m) : base(kernels) { brightnessShift = m; }
    }
}
