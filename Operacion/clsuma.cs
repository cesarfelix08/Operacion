using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacion
{
    internal class clsuma
    {
        public clsuma(int n1, int n2)
        {
            N1 = n1;
            N2 = n2;
        }

        public int N1 { get; }
        public int N2 { get; }

        public int sumar()
        {
            return N1 + N2;
        }
    }
}
