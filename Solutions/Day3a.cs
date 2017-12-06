using System;
using System.Linq;

namespace Challenges
{
    public enum Direction
    {
        Right,
        Left, 
        Down,
        Up
    }
    public class Day3a
    {
        private int input;

        public Day3a(int input)
        {
            this.input = input;
        }

        public int Solve()
        {
            var x = 0;
            var y = 0;
            var boundary = 1;

            var direction = Direction.Right;

            foreach (var number in Enumerable.Range(1, input - 1))
            {
                switch (direction)
                {
                    case Direction.Right:
                        x++;
                        if (x == boundary && y == -boundary)
                        {
                            boundary++;
                        }
                        else if (x == boundary) direction = Direction.Up;
                        break;

                    case Direction.Up:
                        y++;
                        if (y == boundary) direction = Direction.Left;
                        break;

                    case Direction.Left:
                        x--;
                        if (x == -boundary) direction = Direction.Down;
                        break;

                    case Direction.Down:
                        y--;
                        if (y == -boundary) direction = Direction.Right;
                        break;
                }
            }
            return Math.Abs(x) + Math.Abs(y);
            //x++; //go right; - 2 (1,0)
            //y++; // go up - 3 (1, 1)
            //x--;// go left - 4; (0, 1)
            //x--;//go left - 5; (-1, 1)
            //y--; //go down - 6; (-1, 0)
            //y--; //go down - 7; (-1, -1)
            //x++; //go right -8; (0, -1)
            //x++; //go right - 9; (1, -1)
        }
    }
}
