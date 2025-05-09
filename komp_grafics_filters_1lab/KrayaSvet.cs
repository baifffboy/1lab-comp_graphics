﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace komp_grafics_filters_1lab
{
    internal class KrayaSvet : MatrixFilters
    {
        private Image Med;
        private Image Max;
        private Image Kont;

        private Form1 _form1;
        public KrayaSvet()
        {
            kernel = new float[3, 3];
            Kontur n = new Kontur();
            Kont = _form1.MyPictureBox().Image;
            Maximum w = new Maximum();
            Max = _form1.MyPictureBox().Image;
            Mediana q = new Mediana();
            Med = _form1.MyPictureBox().Image;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
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
                    resultR += neighborColor.R * kernel[k + radiusX, l + radiusY];
                    resultG += neighborColor.G * kernel[k + radiusX, l + radiusY];
                    resultB += neighborColor.B * kernel[k + radiusX, l + radiusY];
                }
            }
            return Color.FromArgb(Clamp((int)resultR, 0, 255), Clamp((int)resultG, 0, 255), Clamp((int)resultB, 0, 255));
        }
    }
}
