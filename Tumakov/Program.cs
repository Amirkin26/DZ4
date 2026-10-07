using System;

namespace Tumakov
{
    class Program
    {
        // Упражнение 5.1
        static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        static void TestMax()
        {
            Console.WriteLine($"Тест 1: {(Max(10, 5) == 10 ? "Пройден" : "Не пройден")}");
            Console.WriteLine($"Тест 2: {(Max(5, 10) == 10 ? "Пройден" : "Не пройден")}");
            Console.WriteLine($"Тест 3: {(Max(7, 7) == 7 ? "Пройден" : "Не пройден")}");
            Console.WriteLine($"Тест 4: {(Max(-3, -8) == -3 ? "Пройден" : "Не пройден")}");
        }

        // Упражнение 5.2
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void TestSwap()
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("До обмена:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            Swap(ref a, ref b);

            Console.WriteLine("\nПосле обмена:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            if (a == 20 && b == 10)
            {
                Console.WriteLine("\nТест пройден!");
            }
            else
            {
                Console.WriteLine("\nТест не пройден!");
            }
        }

        // Упражнение 5.3
        static bool Factorial(int n, out int result)
        {
            result = 1;

            if (n < 0)
            {
                result = 0;
                return false;
            }

            try
            {
                checked
                {
                    for (int i = 1; i <= n; i++)
                    {
                        result *= i;
                    }
                }

                return true;
            }
            catch (OverflowException)
            {
                result = 0;
                return false;
            }
        }

        // Упражнение 5.4
        static int Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }

        // Домашнее задание 5.1
        static int NOD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        static int NOD(int a, int b, int c)
        {
            return NOD(NOD(a, b), c);
        }

        // Домашнее задание 5.2
        static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 5.1");
            TestMax();

            Console.WriteLine("\nУпражнение 5.2");
            TestSwap();

            Console.WriteLine("\nУпражнение 5.3");

            int result;

            if (Factorial(5, out result))
            {
                Console.WriteLine($"Факториал = {result}");
            }
            else
            {
                Console.WriteLine("Произошло переполнение!");
            }

            Console.WriteLine("\nУпражнение 5.4");

            int result2 = Factorial(5);
            Console.WriteLine($"Факториал числа 5 = {result2}");

            Console.WriteLine("\nДомашнее задание 5.1");

            Console.WriteLine($"НОД двух чисел: {NOD(24, 18)}");
            Console.WriteLine($"НОД трех чисел: {NOD(24, 18, 30)}");

            Console.WriteLine("\nДомашнее задание 5.2");

            Console.WriteLine($"10-е число Фибоначчи: {Fibonacci(10)}");

            Console.ReadKey();
        }
    }
}