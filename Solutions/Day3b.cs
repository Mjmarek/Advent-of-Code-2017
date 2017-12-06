using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Day3b
    {
        public static readonly int GRID_SIZE = 100;

        public Dictionary<int, Dictionary<int, int>> Grid { get; set; }

        private int input;

        public Day3b(int input)
        {
            this.input = input;

            Grid = new Dictionary<int, Dictionary<int, int>>();

            foreach (var xCoordinate in Enumerable.Range(-(GRID_SIZE / 2), GRID_SIZE))
            {
                Grid[xCoordinate] = new Dictionary<int, int>();

                foreach (var yCoordinate in Enumerable.Range(-(GRID_SIZE / 2), GRID_SIZE))
                {
                    Grid[xCoordinate][yCoordinate] = 0;
                }
            }
            Grid[0][0] = 1;
        }

        public int Solve()
        {
            var x = 0;
            var y = 0;
            var boundary = 1;

            var direction = Direction.Right;

            while (true)
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

                var squareValue = 0;
                squareValue = Grid[x + 1][y] + squareValue;
                squareValue = Grid[x + 1][y + 1] + squareValue;
                squareValue = Grid[x][y + 1] + squareValue;
                squareValue = Grid[x - 1][y + 1] + squareValue;
                squareValue = Grid[x - 1][y] + squareValue;
                squareValue = Grid[x - 1][y - 1] + squareValue;
                squareValue = Grid[x][y - 1] + squareValue;
                squareValue = Grid[x + 1][y - 1] + squareValue;

                Grid[x][y] = squareValue;

                if (squareValue > input) return squareValue;
            }
            throw new Exception("Nope.");
        }
    }
}