using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komp_grafics_filters_1lab
{
    internal class Sobel : MatrixFilters
    {
        private static readonly float[,] sobelKernelX = new float[,]
        {
            { -1, 0, 1 },
            { -2, 0, 2 },
            { -1, 0, 1 }
        };

        private static readonly float[,] sobelKernelY = new float[,]
        {
            { -1, -2, -1 },
            { 0, 0, 0 },
            { 1, 2, 1 }
        };

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;

            float resultRx = 0;
            float resultGx = 0;
            float resultBx = 0;

            float resultRy = 0;
            float resultGy = 0;
            float resultBy = 0;

            // Применяем ядро фильтра Собеля
            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);

                    // Для каждой цветовой компоненты R, G и B применяем ядро фильтра Собеля
                    resultRx += neighborColor.R * sobelKernelX[k + radiusX, l + radiusY];
                    resultGx += neighborColor.G * sobelKernelX[k + radiusX, l + radiusY];
                    resultBx += neighborColor.B * sobelKernelX[k + radiusX, l + radiusY];

                    resultRy += neighborColor.R * sobelKernelY[k + radiusX, l + radiusY];
                    resultGy += neighborColor.G * sobelKernelY[k + radiusX, l + radiusY];
                    resultBy += neighborColor.B * sobelKernelY[k + radiusX, l + radiusY];
                }
            }

            // Вычисляем градиент (оцениваем изменение яркости) для каждой компоненты
            int resultR = Clamp((int)Math.Sqrt(resultRx * resultRx + resultRy * resultRy), 0, 255);
            int resultG = Clamp((int)Math.Sqrt(resultGx * resultGx + resultGy * resultGy), 0, 255);
            int resultB = Clamp((int)Math.Sqrt(resultBx * resultBx + resultBy * resultBy), 0, 255);

            // Возвращаем новый цвет пикселя
            return Color.FromArgb(resultR, resultG, resultB);
        }

        public Sobel(char m) : base(m == 'X' ? sobelKernelX : sobelKernelY){}
    }
}
