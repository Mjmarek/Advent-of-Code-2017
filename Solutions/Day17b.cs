using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Day17b
    {

        public class CircularList<T>
        {
            private int Index { get; set; }
            private int ContentsLength { get; set; } = 1;

            public CircularList(List<T> initialContents = null)
            {
            }

            public int Advance(int steps)
            {
                if (Index + steps >= ContentsLength)
                {
                    Index = (Index + steps) % ContentsLength;
                }
                else
                {
                    Index += steps;
                }
                return Index;
            }

            public void Insert(T value)
            {
                ContentsLength++;
            }
        }

        private int input;

        public Day17b(int input)
        {
            this.input = input;
        }

        public int Solve()
        {
            var spinLock = new CircularList<int>();
            var nextToZero = 0;

            for (int i = 1; i <= 50000000; i++)
            {
                var index = spinLock.Advance(input);
                if (index == 0) nextToZero = i;
                spinLock.Insert(i);
                spinLock.Advance(1);
            }

            return nextToZero;
        }
    }
}
