using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komp_grafics_filters_1lab
{
    internal class Sharpness2 : MatrixFilters
    {
        private static readonly float[,] Ckernel = new float[,]
        {
        { -1, -1, -1 },
        { -1, 9, -1 },
        { -1, -1, -1 }
        };

        public Sharpness2() : base(Ckernel) { }
        
    }
}
