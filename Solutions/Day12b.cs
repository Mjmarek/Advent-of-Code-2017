using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Day12b
    {
        private string input;
        private List<string> visitedNeighbors;

        public Day12b(string input)
        {
            this.input = input;
            visitedNeighbors = new List<string>();
        }

        public int Solve()
        {
            var nodes = input
                .Replace(",", "")
                .Split('\n')
                .Select(line => line.Split(' ').Select(item => item.Trim()).ToArray())
                .ToDictionary(line => line[0], line => line.Skip(2));
            var groupCount = 0;
            while (nodes.Values.Count() > 0)
            {
                var neighbors =  FindNeighbors(nodes.First().Key, nodes).Distinct().Count();
                foreach (var visited in visitedNeighbors)
                {
                    nodes.Remove(visited);
                }
                visitedNeighbors = new List<string>();
                groupCount += 1;
            }
            return groupCount;
        }

        public List<string> FindNeighbors(string currentNode, Dictionary<string, IEnumerable<string>> nodes)
        {
            if (visitedNeighbors.Contains(currentNode)) return new List<string>();

            var neighbors = nodes[currentNode];
            var indirectNeighbors = new List<string>();
            visitedNeighbors.Add(currentNode);
            foreach (var neighbor in neighbors)
            {
                indirectNeighbors.AddRange(FindNeighbors(neighbor, nodes));
            }
            return neighbors.Concat(indirectNeighbors).ToList();
        }
    }
}
