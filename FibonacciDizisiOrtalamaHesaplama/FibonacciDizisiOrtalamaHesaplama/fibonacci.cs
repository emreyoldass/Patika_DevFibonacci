using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciDizisiOrtalamaHesaplama
{
    internal class fibonacci
    {
        int a = 0;
        int b = 1;
        int c = 0;
        public float createarray()
        {
            c = a + b;
            a = b;
            b = c;
            return b;
        }
    }
}

