using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Day4a
    {
        private string input;

        public Day4a(string input)
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

                if (words.Distinct().Count() == words.Count())
                {
                    validPassphraseCount += 1;
                }
            }
            return validPassphraseCount;
        }
    }
}
