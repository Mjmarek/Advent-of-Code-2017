using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Node
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public List<string> Children { get; set; }
        public string Parent { get; set; }
        public int TotalWeight { get; set; }
    }

        public class Day7a
    {
        private string input;

        public Day7a(string input)
        {
            this.input = input;
        }

        public string Solve()
        {
            var inputByLines = input.Split('\n').ToList();
            var towerDescriptions = inputByLines.Select(line => line.Split(' ')).ToList();

            var towerNodes = new List<Node>();

            foreach (var description in towerDescriptions)
            {
                var node = new Node
                {
                    Name = description[0],
                    Weight = ParseWeight(description),
                    Children = ParseChildren(description)
                };
                towerNodes.Add(node);
            }

            var allChildren = towerNodes.Aggregate(new List<string>(), (acc, current) => acc.Concat(current.Children).ToList());
            foreach (var node in towerNodes)
            {
                if (!allChildren.Contains(node.Name)) return node.Name;
            }

            return "foo";
        }

        public int ParseWeight(string[] description)
        {
            var weightInput = description[1];
            return int.Parse(weightInput.Replace("(", "").Replace(")", ""));
        }

        public List<string> ParseChildren(string[] description)
        {
            var hasArrow = description.Length > 2 && description[2] == "->";
            if (!hasArrow) return new List<string>();

            var childrenInput = description.Skip(3).ToArray();
            return childrenInput.Select(child => child.Replace(",", "").Trim()).ToList();
        }
    }
}