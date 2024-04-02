

namespace TextAnalyzer
{
    internal class LongestWordFinder
    {
        public string input;

        public LongestWordFinder(string input)
        {
            this.input = input;
        }
        public string FindLongestWord()
        {
            string[] wordsArr = input.Split(" ");
            int countLetters = 0;
            string longestWord = "";

            foreach (string word in wordsArr)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            return longestWord;
        }

        public int CountWordOccurence(string word)
        {
            int count = 0;
            string[] wordsArr = input.Split(" ");

            foreach (string w in wordsArr)
            {
                if (w == word)
                {
                    count++;
                }

            }
            return count;
        }
    }
}

 
