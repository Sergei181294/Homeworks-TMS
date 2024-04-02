using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    internal class SentencesWithoutCommas
    {

        public string SortingSentences(string input)
        {
            var sentences = input.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(s => s.Trim())
                                  .Where(s => !s.Contains(','))
                                  .ToList();

            return string.Join(" ", sentences);
        }
    }
}
