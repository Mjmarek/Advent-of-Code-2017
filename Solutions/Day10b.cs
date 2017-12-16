using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Day10b
    {
        private string input;
        private List<char> lengths;
        private int[] elements;
        int currentPosition;
        int skipSize;

        public Day10b(string input)
        {
            this.input = input;
        }

        public int Solve()
        {
            var asciiCode = input.ToCharArray();
            var suffix = new char[] { (char)17, (char)31, (char)73, (char)47, (char)23 };
            var lengths = asciiCode.Concat(suffix).ToList();

            var elements = Enumerable.Range(0, 256).ToArray();
            var currentPosition = 0;
            var skipSize = 0;

            KnotHashPass(lengths, elements, ref currentPosition, ref skipSize);
            return elements[0] * elements[1];
        }

        private static void KnotHashPass(List<char> lengths, int[] elements, ref int currentPosition, ref int skipSize)
        {
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

                for (int i = length - 1; i >= 0; i--)
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
        }
    }
}
