using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class Day1b
    {
        public string Input { get; set; }
        public Day1b(string input)
        {
            Input = input;
        }

        public int Solve()
        {
            var solution = 0;
            for (var i = 0; i < (Input.Length); i++)
            {
                var current = Input[i];
                var next = CalculateNext(i);

                if (current == next)
                {
                    solution = ConvertToNumber(current) + solution;
                }
            };
            return solution;
        }

        private char CalculateNext(int i)
        {
            var stepsAway = Input.Length / 2;
            var nextIndex = i + stepsAway;
            if (nextIndex >= Input.Length)
            {
                nextIndex = nextIndex - (Input.Length);
            }
            return Input[nextIndex];
        }

        private static int ConvertToNumber(char toConvert)
        {
            var num = toConvert.ToString();
            return int.Parse(num);
        }
    }
}
