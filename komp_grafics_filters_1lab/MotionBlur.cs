using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komp_grafics_filters_1lab
{
    internal class MotionBlur : MatrixFilters
    {
        int size;

        public MotionBlur(int size ) 
        {
            this.size = size;
            kernel = new float[size, size];
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++)
                {
                    if (i == j) kernel[i, j] = (float)1 * (float)1 / (float)size;
                    else kernel[i, j] = 0;
                }
            }
        }
    }
}
