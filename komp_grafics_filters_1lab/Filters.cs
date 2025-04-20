using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace komp_grafics_filters_1lab
{
    public abstract class Filters 
    {
        public Bitmap processImage(Bitmap sourceImage, System.ComponentModel.BackgroundWorker worker) { //проходимся по всему изображению,
                                                         //создаем новое такого же размера и каждый пиксель
                                                         //прогоняем в фильтре
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height); // создаем копию входной картинки
            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 100)); // вычисляем сколько изображения осталось обработать
                if (worker.CancellationPending) return null;
                for (int j = 0; j < sourceImage.Height; j++) {
                    resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j)); // устанавлиеваем преобразованный пиксель
                     // по координатам i,j
                }
            }
            return resultImage; // выводим преобразованное изображение
        }

        protected abstract Color calculateNewPixelColor(Bitmap sourceImage, int x, int y);  // значение пикселя отфильтрованного изображения

        public int Clamp(int value, int min, int max) { // приводим значения пикселя к допустимому диапазонуs
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
    }
}
