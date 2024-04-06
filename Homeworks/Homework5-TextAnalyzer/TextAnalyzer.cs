

namespace TextAnalyzer
{
    internal class TextAnalyzer
    {
       public List<string> SortedSentence(string input)
        {
            var sentences = input.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                             .Select(s => s.Trim())
                             .ToList();


            List<string> questions = new List<string>();
            List<string> exclamations = new List<string>();

            foreach (var sentence in sentences)
            {
                if (!string.IsNullOrWhiteSpace(sentence))
                {
                    char lastChar = sentence[sentence.Length - 1];
                    Console.WriteLine(lastChar);

                    if (lastChar == '?')
                    {
                        questions.Add(sentence);
                        
                    }
                    else if (lastChar == '!')
                    {
                        exclamations.Add(sentence);
                    }
                }
            }

            Console.WriteLine("Вопросительные предложения:");
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {questions[i]}");
            }

            Console.WriteLine("Восклицательные предложения:");
            for (int i = 0; i < exclamations.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {exclamations[i]}");
            }

            return questions;
        }
    }
}
