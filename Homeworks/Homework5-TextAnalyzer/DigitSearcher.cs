using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    internal class DigitSearcher
    {
        public string FindWordWithMostDigits(string input)
        {
            string[] words = input.Split(" ");

            string wordWithMostDigits = " ";
            int maxDigitCount = 0;

            foreach (string word in words)
            {
                int digitCount = CountDigits(word);
                if (digitCount > maxDigitCount)
                {
                    maxDigitCount = digitCount;
                    wordWithMostDigits = word;
                }
            }
            return wordWithMostDigits;
        }

        private int CountDigits(string word)
        {
            int count = 0;
            foreach (char letter in word)
            {
                if (char.IsDigit(letter))
                {
                    count++;
                }
            }
            return count;
        }

    }
}
