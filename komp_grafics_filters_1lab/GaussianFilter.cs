﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komp_grafics_filters_1lab
{
    internal class GaussianFilter : MatrixFilters
    {
        public void createGaussianKernel(int radius, float sigma) {
            int size = 2 * radius + 1; // опеределяем размер ядра
            kernel = new float[size, size]; // создаем ядро фильтра
            float norm = 0.0f; // коэффициент нормировки ядра
            // расчитываем ядро линейного фильтра
            for (int i = -radius; i <= radius; i++)
            {
                for (int j = -radius; j <= radius; j++)
                {
                    kernel[i + radius, j + radius] = (float)(Math.Exp(-(i * i + j * j) / (sigma * sigma)));
                    norm += kernel[i + radius, j + radius];
                }
            }
            // нормируем ядро
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++)
                {
                    kernel[i, j] /= norm;
                }
            }
        }

        public GaussianFilter()
        {
            createGaussianKernel(3, 2);
        }
    }
}
