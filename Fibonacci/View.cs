using System;

namespace Fibonacci
{
    class View
    {
        private Fibonacci fibonacci;

        private void PrintTask()
        {
            Console.WriteLine("====================================================================================");
            Console.WriteLine("Вывести все числа Фибоначчи, которые удовлетворяют переданному в функцию ограничению:" +
                "\nнаходятся в указанном диапазоне" +
                "\nимеют указанную длину");
            Console.WriteLine("====================================================================================");
        }
        private void PrintHelp()
        {
            Console.WriteLine("====================================================================================");
            Console.WriteLine("Возможные аргументы: " +
                "\n-help - информация о возможных аргументах" +
                "\n-task - информация о задании");
            Console.WriteLine("====================================================================================");
        }
        private void PrintInstruction()
        {
            Console.WriteLine("====================================================================================");
            Console.WriteLine("Параметры для поиска числ Фибоначчи");
            Console.WriteLine("1. По длине: <число> По диапазону чисел: <первое число> <второе число>");
            Console.WriteLine("2. По диапазону чисел: <первое число> <второе число>");
            Console.WriteLine("Введите '1' или '2'");
        }

        public void CheckArguments(string[] args)
        {
            if(args.Length == 0)
            {
                PrintHelp();
            }
            else
            {
                foreach (var arg in args)
                {
                    switch (arg)
                    {
                        case "-help":
                            PrintHelp();
                            break;
                        case "-task":
                            PrintTask();
                            break;
                        default:
                            Console.WriteLine("Указанного аргумента не существует. Чтобы посмотреть список аргументов, укажите '-help'");
                            break;
                    }
                }
            }
        }

        public void ChooseAction()
        {
            bool flag = true;

            while (flag)
            {
                PrintInstruction();
                Console.Write(" > ");
                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        ByLength();
                        flag = false;
                        break;
                    case "2":
                        ByRange();
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Можно ввести только '1' или '2'!");
                        break;
                }
            }

        }

        private void ByRange()
        {
            bool flag = true;
            uint n = 1;
            uint m = 1;

            while (flag)
            {
                Console.WriteLine("Введите: <первое число> <второе число>");
                Console.Write(" > ");
                string[] parameters = Console.ReadLine().Split(' ');

                try
                {
                    if ((!uint.TryParse(parameters[0], out n)) || n == 0)
                    {
                        throw new Exception($"Можно вводить число только в диапазоне [1;{uint.MaxValue}]");
                    }

                    if ((!uint.TryParse(parameters[1], out m)) || m == 0)
                    {
                        throw new Exception($"Можно вводить число только в диапазоне [1;{uint.MaxValue}]");
                    }
                    else if (m <= n)
                    {
                        throw new Exception($"<второе число> должно быть больше чем <первое число>");
                    }
                    flag = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            fibonacci = new Fibonacci(n, m);
            fibonacci.FibonacciByRange();
        }

        private void ByLength()
        {
            uint length = 1;
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Введите: <число>");
                Console.Write(" > ");
                string parameter = Console.ReadLine();

                try
                {
                    if ((!uint.TryParse(parameter, out length)) || length == 0)
                    {
                        throw new Exception($"Можно вводить число только в диапазоне [1;{uint.MaxValue}]");
                    }
                    flag = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            fibonacci = new Fibonacci(length);
            fibonacci.FibonacciByLength();
        }
    }
}
