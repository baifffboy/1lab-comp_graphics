using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komp_grafics_filters_1lab
{
    internal class Maximum : MatrixFilters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            List<int> R = new List<int>();
            List<int> G = new List<int>();
            List<int> B = new List<int>();
            kernel = new float[3, 3];
            int radiusX = kernel.GetLength(0) / 2;

            int radiusY = kernel.GetLength(1) / 2;
            float resR = 0;
            float resG = 0;
            float resB = 0;
            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1); // Clamp используется не по прямому назначению, а чтобы не выйти за размер картинки
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    resR += neighborColor.R * kernel[k + radiusX, l + radiusY];
                    resG += neighborColor.G * kernel[k + radiusX, l + radiusY];
                    resB += neighborColor.B * kernel[k + radiusX, l + radiusY];
                    R.Add(neighborColor.R);
                    G.Add(neighborColor.G);
                    B.Add(neighborColor.B);
                }
            }
            R.Sort();
            G.Sort();
            B.Sort();
            int maxIndex = R.Count-1; // Индекс медианы
            int maxR = R[maxIndex];
            int maxG = G[maxIndex];
            int maxB = B[maxIndex];
            return Color.FromArgb(Clamp((int)maxR, 0, 255), Clamp((int)maxG, 0, 255), Clamp((int)maxB, 0, 255));
        }
    }
}
