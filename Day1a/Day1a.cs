using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//for each item in array, compare to following item
//if they match, add that number to solution
//last number should wrap around to front for evaluation

namespace Solutions
{
    public class Day1a
    {
        public object DigitCount(string input)
        {
            var solution = 0;
            for (var i = 0; i < (input.Length - 1); i++)
            {
                if (input[i] == input[i + 1])
                {
                    var num = (input[i]).ToString();
                    solution = int.Parse(num) + solution;
                }
            };
            return solution;
        }
    }
}
