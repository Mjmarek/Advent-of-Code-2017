using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Day17a
    {

        public class CircularList<T>
        {
            private List<T> Contents { get; set; }
            private int Index { get; set; }

            public CircularList(List<T> initialContents = null)
            {
                if (initialContents == null)
                {
                    Contents = new List<T>();
                }
                else
                {
                    Contents = initialContents;
                }
            }

            public void Append(T value)
            {
                Contents.Add(value);
            }

            public void Advance(int steps)
            {
                if (Index + steps >= Contents.Count)
                {
                    Index = (Index + steps) % Contents.Count;
                }
                else
                {
                    Index += steps;
                }
            }

            public void Insert(T value)
            {
                var beforeInsert = Contents.Take(Index + 1).ToList();
                var insertToEnd = Contents.Skip(Index + 1);
                beforeInsert.Add(value);
                var fullList = beforeInsert.Concat(insertToEnd);
                Contents = fullList.ToList();
                Advance(1);
            }

            internal T CurrentValue()
            {
                return Contents[Index];
            }
        }

        private int input;

        public Day17a(int input)
        {
            this.input = input;
        }

        public int Solve()
        {
            var spinLock = new CircularList<int>();
            spinLock.Append(0);

            for (int i = 1; i <= 2017; i++)
            {
                spinLock.Advance(input);
                spinLock.Insert(i);
            }

            spinLock.Advance(1);
            return spinLock.CurrentValue();
        }
    }
}
