using System;
using System.Linq;

namespace Challenges
{
    public class Day2b
    {
        private string input;

        public Day2b(string input)
        {
            this.input = input;
        }

        public int Solve()
        {
            var checksum = 0;

            var inputByLines = input.Split('\n');
            foreach (var line in inputByLines)
            {
                var cells = line.Split(' ', '\t');
                var cellsAsInts = cells.Select(cell => int.Parse(cell)).ToArray();
                var evenlyDivide = new EvenlyDivide(cellsAsInts);
                var quotient = evenlyDivide.FindEvenQuotient();
                checksum += quotient;
            }

            return checksum;
        }
    }

    public class EvenlyDivide
    {
        public int[] Row { get; set; }

        public EvenlyDivide(int[] row)
        {
            Row = row;
        }

        public int FindEvenQuotient()
        {
            if (Row == null) throw new ArgumentException("Array must not be null.");
            if (Row.Length < 2) throw new ArgumentException("Array must contain at least 2 elements.");

            for (int i = 0; i < Row.Length; i++)
            {
                var current = Row[i];

                for (int j = 0; j < Row.Length; j++)
                {
                    if (i == j)
                        continue;

                    var compare = Row[j];

                    if (current % compare == 0)
                        return current / compare;
                }
            }

            return 0;
        }
    }
}
