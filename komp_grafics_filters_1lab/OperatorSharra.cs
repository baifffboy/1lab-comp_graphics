using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komp_grafics_filters_1lab
{
    internal class OperatorSharra : MatrixFilters
    {
        private static readonly float[,] OperatorSharraKernelX = new float[,]
        {
            { 3, 0, -3 },
            { 10, 0, -10 },
            { 3, 0, -3 }
        };

        private static readonly float[,] OperatorSharraKernelY = new float[,]
        {
            { 3, 10, 3 },
            { 0, 0, 0 },
            { -3, -10, -3 }
        };

        public OperatorSharra(bool xAxis) : base(xAxis ? OperatorSharraKernelX : OperatorSharraKernelY) { }
    }
}
