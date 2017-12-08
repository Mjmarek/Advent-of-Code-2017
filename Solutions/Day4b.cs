using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Day4b
    {
        private string input;

        public Day4b(string input)
        {
            this.input = input;
        }

        public int Solve()
        {
            var validPassphraseCount = 0;

            var inputByLines = input.Split('\n');
            foreach (var line in inputByLines)
            {
                var words = line.Split(' ').Select(word => word.Trim());

                var wordsSort = words.Select(word => String.Concat(word.OrderBy(c => c))).ToList();

                if (wordsSort.Distinct().Count() == wordsSort.Count())
                {
                    validPassphraseCount += 1;
                }
            }
            return validPassphraseCount;
        }
    }
}
