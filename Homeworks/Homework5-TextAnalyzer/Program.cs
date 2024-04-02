﻿

namespace TextAnalyzer
{
    class StringReader
    {
        static void Main()
        {

            Console.WriteLine("Введите строку..");
            string input = Console.ReadLine();

            DigitSearcher digitSearcher = new DigitSearcher();
            LongestWordFinder wordFinder = new LongestWordFinder(input);


            while (true)
            {
                Console.WriteLine("Меню выбора действий: ");
                Console.WriteLine("1.Найти слова содержащие максимальное количество цифр.");
                Console.WriteLine("2.Найти самое длинное слово и определить, сколько раз оно встретилось в тексте.");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        string wordWithMostDigits = digitSearcher.FindWordWithMostDigits(input);
                        Console.WriteLine($"Слово с наибольшим количеством цифр: {wordWithMostDigits}");
                        break;
                    case 2:
                        string longestWord = wordFinder.FindLongestWord();
                        int count = wordFinder.CountWordOccurence(longestWord);
                        Console.WriteLine($"Самое длинное слово: {longestWord} встречалось в тексте {count} раз.");
                        break;
                }
            }
        }
    }
}