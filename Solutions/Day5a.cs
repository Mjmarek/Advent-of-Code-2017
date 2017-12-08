using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Day5a
    {
        private string input;

        public Day5a(string input)
        {
            this.input = input;
        }

        public int Solve()
        {
            var steps = 0;

            var jumps = input.Split('\n').Select(jump => int.Parse(jump.Trim())).ToArray();

            var currentPosition = 0;

            while(currentPosition < jumps.Length)
            {
                var currentValue = 0;

                currentValue = jumps[currentPosition];

                jumps[currentPosition] = currentValue + 1;

                currentPosition += currentValue;

                steps += 1;
            }

            return steps;
        }
    }
}
