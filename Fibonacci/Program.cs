﻿using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleController consoleController = new ConsoleController(args);
            consoleController.Start();

            Console.WriteLine("Программа завершена");
            Console.ReadKey();
        }

       
    }
}
