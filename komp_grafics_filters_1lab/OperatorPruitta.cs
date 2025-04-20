using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komp_grafics_filters_1lab
{
    internal class OperatorPruitta : MatrixFilters
    {
        private static readonly float[,] OperatorPruittaKernelX = new float[,]
        {
            { -1, 0, 1 },
            { -1, 0, 1 },
            { -1, 0, 1 }
        };

        private static readonly float[,] OperatorPruittaKernelY = new float[,]
        {
            { -1, -1, -1 },
            { 0, 0, 0 },
            { 1, 1, 1 }
        };

        public OperatorPruitta(bool xAxis) : base(xAxis ? OperatorPruittaKernelX : OperatorPruittaKernelY) { }
    }
}

