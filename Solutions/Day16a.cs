using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Day16a
    {
        private class PartnerMove : DanceMove
        {
            private char partner1;
            private char partner2;

            public PartnerMove(char partner1, char partner2)
            {
                this.partner1 = partner1;
                this.partner2 = partner2;
            }

            public override void Dance(char[] programs)
            {
                var partner1Position = Array.IndexOf(programs, partner1);
                var partner2Position = Array.IndexOf(programs, partner2);
                programs[partner1Position] = partner2;
                programs[partner2Position] = partner1;
            }
        }

        private class ExchangeMove : DanceMove
        {
            private int position1;
            private int position2;

            public ExchangeMove(int position1, int position2)
            {
                this.position1 = position1;
                this.position2 = position2;
            }

            public override void Dance(char[] programs)
            {
                var program1 = programs[position1];
                var program2 = programs[position2];
                programs[position1] = program2;
                programs[position2] = program1;
            }
        }

        private class SpinMove : DanceMove
        {
            private int spinNumber;

            public SpinMove(int spinNumber)
            {
                this.spinNumber = spinNumber;
            }

            public override void Dance(char[] programs)
            {
                var spinPrograms = programs.Skip(programs.Length-spinNumber).ToArray();
                var notSpinPrograms = programs.Take(programs.Length - spinNumber).ToArray();
                Array.ConstrainedCopy(spinPrograms, 0, programs, 0, spinPrograms.Length);
                Array.ConstrainedCopy(notSpinPrograms, 0, programs, spinPrograms.Length, notSpinPrograms.Length);
            }
        }

        private abstract class DanceMove
        {
            public abstract void Dance(char[] programs);

            public static DanceMove Create(string danceMoveInput)
            {
                switch (danceMoveInput[0])
                {
                    case 's':
                        return new SpinMove(int.Parse(danceMoveInput.Replace("s","")));
                    case 'x':
                        var dancePositions = danceMoveInput.Replace("x","").Split('/');
                        return new ExchangeMove(int.Parse(dancePositions[0]), int.Parse(dancePositions[1]));
                    case 'p':
                        var dancePartners = string.Concat(danceMoveInput.Skip(1)).Split('/');
                        return new PartnerMove(dancePartners[0][0], dancePartners[1][0]);
                    default:
                        return null;
                }
            }
        }

        private char[] programs;
        private string danceMovesInput;

        public Day16a(string programs, string danceMovesInput)
        {
            this.programs = programs.ToCharArray();
            this.danceMovesInput = danceMovesInput;
        }

        public string Solve()
        {
            var danceMoves = danceMovesInput.Split(',').Select(move => DanceMove.Create(move));
            foreach (var move in danceMoves)
            {
                move.Dance(programs);
            }
            return string.Concat(programs);
        }
    }
}
