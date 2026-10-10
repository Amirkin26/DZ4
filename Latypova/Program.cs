
namespace Latypova
{
    class Program
    {
        static void Main()
        {
            // Задание 1
            int[] numbers = new int[20];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = random.Next(1, 101);

            Console.WriteLine("Задание 1");
            Console.WriteLine("Исходный массив:");
            PrintArray(numbers);

            Console.Write("Введите первое число: ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int second = int.Parse(Console.ReadLine());

            int firstIndex = Array.IndexOf(numbers, first);
            int secondIndex = Array.IndexOf(numbers, second);

            if (firstIndex != -1 && secondIndex != -1)
            {
                (numbers[firstIndex], numbers[secondIndex]) =
                    (numbers[secondIndex], numbers[firstIndex]);
            }

            Console.WriteLine("Получившийся массив:");
            PrintArray(numbers);


            // Задание 2
            Console.WriteLine("\nЗадание 2");

            int[] array = { 2, 4, 6, 8, 10 };

            int sum = GetSum(array);

            int product = 0;
            GetProduct(array, ref product);

            double average;
            GetAverage(array, out average);

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product}");
            Console.WriteLine($"Среднее арифметическое: {average}");


            // Задание 3
            Console.WriteLine("\nЗадание 3");
            Console.WriteLine("Введите цифру от 0 до 9.");
            Console.WriteLine("Для выхода введите exit или закрыть.");

            while (true)
            {
                Console.Write("Введите число: ");
                string input = Console.ReadLine();

                if (input == "exit" || input == "закрыть")
                    break;

                try
                {
                    int number = int.Parse(input);

                    if (number < 0 || number > 9)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();

                        Console.WriteLine("Ошибка! Число должно быть от 0 до 9.");

                        System.Threading.Thread.Sleep(3000);

                        Console.ResetColor();
                        Console.Clear();

                        continue;
                    }

                    PrintDigit(number);
                }
                catch (FormatException)
                {
                    throw new Exception("Введено не число!");
                }
            }


            // Задание 4
            Console.WriteLine("\nЗадание 4");

            Ded[] grandfathers =
            {
                new Ded(
                    "Иван",
                    GrumpinessLevel.Спокойный,
                    new string[] { "Тады!" }
                ),

                new Ded(
                    "Пётр",
                    GrumpinessLevel.Недовольный,
                    new string[] { "Опять дождь!", "Тады!" }
                ),

                new Ded(
                    "Семён",
                    GrumpinessLevel.Ворчливый,
                    new string[] { "Чёрт!", "Опять дождь!", "Тады!" }
                ),

                new Ded(
                    "Николай",
                    GrumpinessLevel.ОченьВорчливый,
                    new string[] { "Блин!", "Чёрт!", "Тады!", "Опять всё сломали!" }
                ),

                new Ded(
                    "Алексей",
                    GrumpinessLevel.ОченьВорчливый,
                    new string[]
                    {
                        "Проститутки!",
                        "Блин!",
                        "Чёрт!",
                        "Дураки!",
                        "Тады!"
                    }
                )
            };

            string[] badWords =
            {
                "проститутки",
                "блин",
                "чёрт",
                "дураки"
            };

            for (int i = 0; i < grandfathers.Length; i++)
            {
                int badWordsCount = grandfathers[i].CheckBadWords(badWords);

                Console.WriteLine(
                    $"{grandfathers[i].Name}: фингалов = {badWordsCount}");
            }
        }


        // Задание 1
        static void PrintArray(int[] array)
        {
            foreach (int number in array)
                Console.Write(number + " ");

            Console.WriteLine();
        }


        // Задание 2
        static int GetSum(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
                sum += number;

            return sum;
        }

        static void GetProduct(int[] numbers, ref int product)
        {
            product = 1;

            foreach (int number in numbers)
                product *= number;
        }

        static void GetAverage(int[] numbers, out double average)
        {
            average = (double)GetSum(numbers) / numbers.Length;
        }


        // Задание 3
        static void PrintDigit(int number)
        {
            string[] digits =
            {
                " ### \n#   #\n#   #\n#   #\n ### ", // 0
                "  #  \n ##  \n  #  \n  #  \n ### ", // 1
                " ### \n#   #\n   # \n  #  \n#####", // 2
                " ### \n#   #\n  ## \n#   #\n ### ", // 3
                "#   #\n#   #\n#####\n    #\n    #", // 4
                "#####\n#    \n#### \n    #\n#### ", // 5
                " ### \n#    \n#### \n#   #\n ### ", // 6
                "#####\n    #\n   # \n  #  \n #   ", // 7
                " ### \n#   #\n ### \n#   #\n ### ", // 8
                " ### \n#   #\n ####\n    #\n ### "  // 9
            };

            Console.WriteLine(digits[number]);
        }
    }
}