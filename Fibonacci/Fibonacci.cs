using System;

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

        public void FibonacciByLength()
        {
            uint j = 1;
            for (uint i = 1; i <= length; i += j)
            {
                Console.Write(i + " ");
                j = i - j;
            }

            Console.WriteLine();
        }
        public void FibonacciByRange()
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
