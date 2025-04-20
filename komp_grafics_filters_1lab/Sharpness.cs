using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komp_grafics_filters_1lab
{
    internal class Sharpness : MatrixFilters
    {
        private static readonly float[,] kernel = new float[,]
        {
            { 0, -1, 0 },
            { -1, 5, -1 },
            { 0, -1, 0 }
        };

        public Sharpness() : base(kernel) { }
    }
}   
