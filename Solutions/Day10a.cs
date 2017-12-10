using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Day10a
    {
        private int inputElementCount = 5;
        private string inputLengths;

        public Day10a(int inputElementCount, string inputLengths)
        {
            this.inputElementCount = inputElementCount;
            this.inputLengths = inputLengths;
        }

        public int Solve()
        {
            var lengths = inputLengths.Split(',').Select(length => int.Parse(length)).ToArray();
            var elements = Enumerable.Range(0, inputElementCount).ToArray();

            var currentPosition = 0;
            var skipSize = 0;

            foreach (var length in lengths)
            {
                var reverseList = new List<int>();

                var currentReverseListPosition = currentPosition;
                for (int i = 0; i < length; i++)
                {
                    if (currentReverseListPosition >= elements.Length)
                    {
                        currentReverseListPosition = 0;
                    }
                    reverseList.Add(elements[currentReverseListPosition]);

                    currentReverseListPosition++;
                }

                for (int i = length-1; i >= 0; i--)
                {
                    if (currentPosition >= elements.Length)
                    {
                        currentPosition = 0;
                    }
                    elements[currentPosition] = reverseList[i];

                    currentPosition++;
                }

                if (currentPosition + skipSize >= elements.Length)
                {
                    currentPosition = currentPosition + skipSize - elements.Length;
                }
                else
                {
                    currentPosition += skipSize;
                }

                skipSize += 1;
            }
            return elements[0] * elements[1];
        }
    }
}
