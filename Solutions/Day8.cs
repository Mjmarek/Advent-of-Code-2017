using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Day8
    {
        private string input;
        public int HighestValue { get; set; }

        public Day8(string input)
        {
            this.input = input;
            HighestValue = 0;
        }

        public int Solve()
        {
            var inputByLines = input.Split('\n').Select(line => line.Split(' ')).ToList();
            Dictionary<string, int> registers = new Dictionary<string, int>();

            foreach (var line in inputByLines)
            {
                var register = line[0];
                registers[register] = 0;
            }

            foreach (var line in inputByLines)
            {
                var shouldInc = line[1] == "inc";
                var shouldDec = line[1] == "dec";
                var value = int.Parse(line[2]);
                var shouldExecute = CheckCondition(line, registers);

                if (shouldExecute)
                {
                    if (shouldInc)
                    {
                        var register = line[0];
                        registers[register] += value;
                    }
                    else
                    {
                        var register = line[0];
                        registers[register] -= value;
                    }

                    if (HighestValue < registers.Values.Max())
                    {
                        HighestValue = registers.Values.Max();
                    }
                }
            }
            return registers.Values.Max();
        }

        private bool CheckCondition(string[] line, Dictionary<string, int> registers)
        {
            var registerValue = registers[line[4]];
            var value = int.Parse(line[6]);
            var comparison = line[5];

            switch(comparison)
            {
                case "!=":
                    return registerValue != value;

                case "==":
                    return registerValue == value;

                case ">":
                    return registerValue > value;

                case "<":
                    return registerValue < value;

                case ">=":
                    return registerValue >= value;

                case "<=":
                    return registerValue <= value;

                default :
                    return false;
            }
        }
    }
}
