using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibonacci;
            uint n, m;
            string[] param;

            Console.WriteLine("Введите параметры поиска числ Фибоначчи");
            Console.WriteLine("1. Диапазон чисел: <число a> <число b>");
            Console.WriteLine("2. Длина: <число> ");
            Console.Write(" > ");

            param = Console.ReadLine().Split(' ');

            if (param.Length == 1)
            {
                n = Convert.ToUInt32(param[0]);

                fibonacci = new Fibonacci(n);
                fibonacci.fibonacciLength();
            }
            else if (param.Length == 2)
            {
                n = Convert.ToUInt32(param[0]);
                m = Convert.ToUInt32(param[1]);

                fibonacci = new Fibonacci(n, m);
                fibonacci.fibonacciRange();
            }
            else
            {
                Console.WriteLine("Ошибка ввода параметров");
            }

            Console.WriteLine("Программа завершена");
            Console.ReadKey();

        }
    }
}
