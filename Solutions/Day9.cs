using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Group
    {
        public List<Group> InnerGroups { get; set; }
        public Group Parent { get; set; }
        public bool IsRootLevel => Parent == null;

        public Group()
        {
            InnerGroups = new List<Group>();
        }
    }

    public class Day9
    {
        private string input;
        public int GarbageCount {get;set;}

        public Day9(string input)
        {
            this.input = input;
            GarbageCount = 0;
        }

        public int Solve()
        {
            var groups = new List<Group>();
            Group currentGroup = null;
            var isInsideGarbage = false;
            var regex = new System.Text.RegularExpressions.Regex("!.");
            var inputWithoutCancels = regex.Replace(input, "");
            foreach (var c in inputWithoutCancels)
            {
                if (c == '>') isInsideGarbage = false;
                if (isInsideGarbage) {
                    GarbageCount++;
                    continue;
                }

                switch (c)
                {
                    case '{':
                        var g = new Group();
                        if (currentGroup != null)
                        {
                            g.Parent = currentGroup;
                            currentGroup.InnerGroups.Add(g);
                        }
                        else
                        {
                            groups.Add(g);
                        }
                        currentGroup = g;
                        break;
                    case '}':
                        currentGroup = currentGroup.Parent;
                        break;
                    case '<':
                        isInsideGarbage = true;
                        break;
                    default:
                        break;
                }
            }


            return ScoreGroups(groups, 1);
        }

        private int ScoreGroups(List<Group> groups, int levelOfNesting)
        {
            var score = groups.Count() * levelOfNesting;
            foreach (var group in groups)
            {
                score += ScoreGroups(group.InnerGroups, levelOfNesting + 1);
            }
            return score;
        }
    }
}
