using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Day7b
    {
        private string input;

        public Day7b(string input)
        {
            this.input = input;
        }

        public int Solve()
        {
            var inputByLines = input.Split('\n').ToList();
            var towerDescriptions = inputByLines.Select(line => line.Split(' ')).ToList();

            var towerNodes = new Dictionary<string, Node>();

            foreach (var description in towerDescriptions)
            {
                var node = new Node
                {
                    Name = description[0],
                    Weight = ParseWeight(description),
                    Children = ParseChildren(description)
                };
                towerNodes.Add(node.Name, node);
            }

            PopulateParents(towerNodes);
            PopulateTotalWeight(towerNodes);
            return FindCorrectedWeight(towerNodes);
        }

        private static void PopulateTotalWeight(Dictionary<string, Node> towerNodes)
        {
            foreach (var node in towerNodes.Values)
            {
                var totalWeight = node.Weight;
                int childrenWeight = SumChildWeight(towerNodes, node);
                totalWeight += childrenWeight;
                node.TotalWeight = totalWeight;
            }
        }

        private static int FindCorrectedWeight(Dictionary<string, Node> towerNodes)
        {
            var unbalancedNode = FindNodeWithUnbalancedChildren(towerNodes);
            var allChildren = unbalancedNode.Children.Select(child => towerNodes[child]).ToList();
            var incorrectNode = allChildren.GroupBy(child => child.TotalWeight).Single(grouping => grouping.ToList().Count() == 1).Single();
            var correctNodes = allChildren.GroupBy(child => child.TotalWeight).Single(grouping => grouping.ToList().Count() != 1).ToList();
            var correct = correctNodes.First().TotalWeight;

            var difference = correct - incorrectNode.TotalWeight;
            return incorrectNode.Weight + difference; 
        }

        private static Node FindNodeWithUnbalancedChildren(Dictionary<string, Node> towerNodes)
        {
            var rootNode = towerNodes.Values.Single(node => node.Parent == null);
            var allChildrenNodes = rootNode.Children.Select(child => towerNodes[child]);
            var childrenWeights = allChildrenNodes.Select(child => child.TotalWeight);

            foreach (var child in allChildrenNodes)
            {
                var unbalancedNode = FindUnbalanced(towerNodes, child);
                bool didFindUnbalancedNodeInBranch = unbalancedNode != null;
                if (didFindUnbalancedNodeInBranch) return unbalancedNode;
            }
            return null;
        }

        private static Node FindUnbalanced(Dictionary<string, Node> towerNodes, Node node)
        {
            var allChildrenNodes = node.Children.Select(child => towerNodes[child]);
            var childrenWeights = allChildrenNodes.Select(child => child.TotalWeight);
            var isUnbalanced = childrenWeights.Distinct().Count() > 1;
            foreach (var childName in node.Children)
            {
                var unbalancedNode = FindUnbalanced(towerNodes, towerNodes[childName]);
                if (unbalancedNode != null)
                {
                    var y = FindUnbalanced(towerNodes, unbalancedNode);
                    bool foundChildUnbalanced = y != null;


                    if (!foundChildUnbalanced) return unbalancedNode;
                    return FindUnbalanced(towerNodes, unbalancedNode);
                }
            }
            if (isUnbalanced) return node;

            return null;
        }



        private static int SumChildWeight(Dictionary<string, Node> towerNodes, Node node)
        {
            var totalWeight =  node.Children.Select(child => towerNodes[child].Weight).Sum();
            foreach (var childNodeName in node.Children)
            {
                var childNode = towerNodes[childNodeName];
                var hasGrandchildren = childNode.Children.Count > 0;
                if (hasGrandchildren)
                {
                    totalWeight += SumChildWeight(towerNodes, childNode);
                }
            }

            return totalWeight;
        }

        private static void PopulateParents(Dictionary<string, Node> towerNodes)
        {
            foreach (var node in towerNodes.Values)
            {
                foreach (var potentialParent in towerNodes.Values)
                {
                    var isParent = potentialParent.Children.Contains(node.Name);
                    if (isParent) node.Parent = potentialParent.Name;
                }
            }
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