

namespace TextAnalyzer
{
    internal class DigitToWordConverter
    {
        public string Converter (string input)
        {
            string[] numbers = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };

            for (int i = 0; i < numbers.Length; i++)
            {
                input = input.Replace(i.ToString(), numbers[i]);
            }

            return input;
        }
    }
}
