using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class Day1a
    {
        public object DigitCount(string input)
        {
            var solution = 0;
            for (var i = 0; i < (input.Length); i++)
            {
                if (i == input.Length - 1)
                {
                    if (input[i] == input[0])
                    {
                        var num = (input[i]).ToString();
                        solution = int.Parse(num) + solution;
                    }
                }
                else if (input[i] == input[i + 1])
                {
                    var num = (input[i]).ToString();
                    solution = int.Parse(num) + solution;
                }
            };
            return solution;
        }
    }
}
