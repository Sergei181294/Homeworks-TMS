

namespace TextAnalyzer
{
    internal class SameWordsByFirstLetter
    {
        public string SameWordsFinder(string input)
        {
            string[] words = input.Split(new char[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";

            foreach (string word in words)
            {
                if (word.Length > 1 && char.ToLower(word[0]) == char.ToLower(word[word.Length - 1]))
                {
                    result += word + " ";
                }
            }
            return result.Trim();
        }

    }
}
