using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        private uint length;
        private uint n;
        private uint m;

        public Fibonacci() { }
        public Fibonacci(uint length)
        {
            this.length = length;
        }
        public Fibonacci(uint n, uint m)
        {
            this.n = n;
            this.m = m;
        }

        public void fibonacciLength()
        {
            uint j = 1;
            for (uint i = 1; i <= length; i += j)
            {
                Console.Write(i + " ");
                j = i - j;
            }

            Console.WriteLine();
        }

        public void fibonacciRange()
        {
            uint j = 1;
            for (uint i = n; i <= m; i += j)
            {
                Console.Write(i + " ");
                j = i - j;
            }

            Console.WriteLine();
        }
    }
}
