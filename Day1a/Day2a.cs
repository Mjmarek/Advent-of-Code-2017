using System.Linq;

namespace Solutions
{
    public class Day2a
    {
        private string input;

        public Day2a(string input)
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
                var cellsAsInts = cells.Select(cell => int.Parse(cell)).ToList();
                var smallest = cellsAsInts.Min();
                var largest = cellsAsInts.Max();
                var difference = largest - smallest;
                checksum += difference;
            }

            return checksum;
        }
    }
}
