using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class Day1a
    {
        public int DigitCount(string input)
        {
            var solution = 0;
            for (var i = 0; i < (input.Length); i++)
            {
                var current = input[i];
                var next = (i == input.Length - 1) ? input[0] : input[i + 1];

                if (current == next)
                {
                    solution = ConvertToNumber(current) + solution;
                }
            };
            return solution;
        }

        private static int ConvertToNumber(char toConvert)
        {
            var num = toConvert.ToString();
            return int.Parse(num);
        }
    }
}
