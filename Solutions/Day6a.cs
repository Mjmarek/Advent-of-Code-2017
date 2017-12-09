using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Day6a
    {
        private string input;

        public Day6a(string input)
        {
            this.input = input;
        }

        public int Solve()
        {
            var cycles = 0;

            var blocks = input.Split(' ','\t').Select(block => int.Parse(block.Trim())).ToList();

            var states = new List<string>();

            var initialState = String.Join(" ", blocks.Select(block => block.ToString()));

            states.Add(initialState);

            while (true)
            {
                var maxValue = blocks.Max();
                var maxValueIndex = blocks.IndexOf(maxValue);

                blocks[maxValueIndex] = 0;
                var blockIndex = maxValueIndex == blocks.Count - 1 ? 0 : maxValueIndex + 1;
                for (int i = 0; i < maxValue; i++)
                {
                    blocks[blockIndex] += 1;

                    if (blockIndex == blocks.Count - 1) blockIndex = 0;
                    else blockIndex++;
                }
                cycles += 1;

                var currentState = String.Join(" ", blocks.Select(block => block.ToString()));

                if (states.Contains(currentState)) break;
                states.Add(currentState);
            }
            return cycles;
        }
    }
}