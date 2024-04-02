

namespace TextAnalyzer
{
    class StringReader
    {
        static void Main()
        {
            Console.WriteLine("Enter a text..");
            string input = Console.ReadLine();

            DigitSearcher digitSearcher = new DigitSearcher();
            LongestWordFinder wordFinder = new LongestWordFinder(input);
            DigitToWordConverter converter = new DigitToWordConverter();
            TextAnalyzer textAnalyzer = new TextAnalyzer();
            SentencesWithoutCommas sentencesWithoutCommas = new SentencesWithoutCommas();


            while (true)
            {
                Console.WriteLine("Menu of actions: ");
                Console.WriteLine("1. Find words containing the maximum number of digits.");
                Console.WriteLine("2. Find the longest word and determine how many times it occurred in the text.");
                Console.WriteLine("3. Replace digits from 0 to 9 with words 'zero', 'one', ..., 'nine'.");
                Console.WriteLine("4.Display the question sentences first, and then the exclamation sentences.");
                Console.WriteLine("5.Display only the sentences that do not contain commas.");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        string wordWithMostDigits = digitSearcher.FindWordWithMostDigits(input);
                        Console.WriteLine($"Word with the most digits: {wordWithMostDigits}");
                        break;
                    case 2:
                        string longestWord = wordFinder.FindLongestWord();
                        int count = wordFinder.CountWordOccurence(longestWord);
                        Console.WriteLine($"The longest word: {longestWord} appeared in the text {count} times.");
                        break;
                    case 3:
                        string convertedString = converter.Converter(input);
                        Console.WriteLine($"The new string looks like this: {convertedString}");
                        break;
                    case 4:
                        List<string> sentences = textAnalyzer.SortedSentence(input);
                        foreach (string sentence in sentences)
                        {
                            Console.WriteLine(sentence);
                        }
                        break;
                    case 5:
                        string formattedText = sentencesWithoutCommas.SortingSentences(input);
                        Console.WriteLine($"Sentences without commas: {formattedText}");
                        break;
                }
            }
        }
    }
}
