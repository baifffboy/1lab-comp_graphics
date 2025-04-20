using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komp_grafics_filters_1lab
{
    internal class Kontur : MatrixFilters
    {
        private static readonly float[,] KonturKernel = new float[,]
        {
            { -1, -1, -1 },
            { -1, 8, -1 },
            { -1, -1, -1 }
        };

        public Kontur() : base(KonturKernel) { }
    }
}
