using System;

namespace TextAnalyzer
{
    class StringReader
    {
        static void Main()
        {

            Console.WriteLine("Введите строку..");
            string input = Console.ReadLine();

            DigitSearcher digitSearcher = new DigitSearcher();


            while (true)
            {
                Console.WriteLine("Меню выбора действий: ");
                Console.WriteLine("1.Найти слова содержащие максимальное количество цифр.");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        string wordWithMostDigits = digitSearcher.FindWordWithMostDigits(input);
                        Console.WriteLine($"Слово с наибольшим количеством цифр: {wordWithMostDigits}");
                        break;
                }
            }
        }
    }
}
