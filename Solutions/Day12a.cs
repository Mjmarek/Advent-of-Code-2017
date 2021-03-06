﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Day12a
    {
        private string input;
        private List<string> visitedNeighbors;

        public Day12a(string input)
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

            return FindNeighbors(nodes.First().Key, nodes).Distinct().Count();
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