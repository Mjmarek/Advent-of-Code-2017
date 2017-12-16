using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public enum DanceType
    {
        Spin,
        Partner,
        Exchange,
        Flat
    }
    public class Day16
    {
        private class ManyPartnerMove : DanceMove
        {
            public override DanceType Type => DanceType.Flat;
            private Dictionary<char, char> ops;

            public ManyPartnerMove(List<DanceMove> toFlatten, int programsCount)
            {
                var dancers = "abcdefghijklmnop".ToCharArray().Take(programsCount).ToArray();
                var start = string.Concat(dancers);
                foreach (var move in toFlatten)
                {
                    move.Dance(dancers);
                }
                var end = string.Concat(dancers);
                ops = new Dictionary<char, char>();
                for (int i = 0; i < programsCount; i++)
                {
                    var startValue = start[i];
                    var endIndex = end.IndexOf(startValue);
                    var endValue = end[i];

                    ops[startValue] = endValue;
                }
            }

            public override void Dance(char[] programs)
            {
                var result = new char[programs.Length];
                for (int i = 0; i < programs.Length; i++)
                {
                    var startValue = programs[i];
                    var replacement = ops[startValue];
                    
                    result[i] = replacement;
                }
                Array.Copy(result, programs, programs.Length);
            }
        }
        private class FlattenedMove : DanceMove
        {
            public override DanceType Type => DanceType.Flat;
            private int[] ops;

            public FlattenedMove(List<DanceMove> toFlatten, int programsCount)
            {
                var dancers = "abcdefghijklmnop".ToCharArray().Take(programsCount).ToArray();
                var start = string.Concat(dancers);
                foreach (var move in toFlatten)
                {
                    move.Dance(dancers);
                }
                var end = string.Concat(dancers);
                ops = new int[programsCount];
                for (int i = 0; i < programsCount; i++)
                {
                    var startValue = start[i];
                    var endIndex = end.IndexOf(startValue);
                    ops[i] = endIndex;
                }
            }

            public override void Dance(char[] programs)
            {
                var result = new char[programs.Length];
                for (int i = 0; i < programs.Length; i++)
                {
                    var toMove = programs[i];
                    var destIndex = ops[i];
                    result[destIndex] = toMove;
                }
                Array.Copy(result, programs, programs.Length);
            }
        }
        private class PartnerMove : DanceMove
        {
            public char partner1;
            public char partner2;
            public override DanceType Type => DanceType.Partner;

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
            public override DanceType Type => DanceType.Exchange;

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
            public override DanceType Type => DanceType.Spin;

            public SpinMove(int spinNumber)
            {
                this.spinNumber = spinNumber;
            }

            public override void Dance(char[] programs)
            {
                var spinPrograms = programs.Skip(programs.Length - spinNumber).ToArray();
                var notSpinPrograms = programs.Take(programs.Length - spinNumber).ToArray();
                Array.ConstrainedCopy(spinPrograms, 0, programs, 0, spinPrograms.Length);
                Array.ConstrainedCopy(notSpinPrograms, 0, programs, spinPrograms.Length, notSpinPrograms.Length);
            }
        }

        private abstract class DanceMove
        {
            public abstract void Dance(char[] programs);
            public abstract DanceType Type { get; }
            public static DanceMove Create(string danceMoveInput)
            {
                switch (danceMoveInput[0])
                {
                    case 's':
                        return new SpinMove(int.Parse(danceMoveInput.Replace("s", "")));
                    case 'x':
                        var dancePositions = danceMoveInput.Replace("x", "").Split('/');
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
        private int danceCount;

        public Day16(string programs, string danceMovesInput, int danceCount = 1)
        {
            this.programs = programs.ToCharArray();
            this.danceMovesInput = danceMovesInput;
            this.danceCount = danceCount;
        }

        public string Solve()
        {
            var danceMoves = danceMovesInput.Split(',').Select(move => DanceMove.Create(move));
            var optimizedDanceMoves = TuneMoves(danceMoves);
            var repeats = new List<string>();

            for (int i = 0; i < danceCount; i++)
            {
                //var c = string.Concat(programs);
                //if (repeats.Contains(c)) {
                //    var remainder = 1000000000 % repeats.Count();
                //    return repeats[remainder];
                //}
                //repeats.Add(c);

                foreach (var move in optimizedDanceMoves)
                {
                    move.Dance(programs);
                }
            }
            return string.Concat(programs);
        }

        private List<DanceMove> TuneMoves(IEnumerable<DanceMove> danceMoves)
        {
            var flat = danceMoves.Where(m => m.Type != DanceType.Partner);
            var p = danceMoves.Where(m => m.Type == DanceType.Partner);
            var danceMovesList = flat.Concat(p).ToList();
            var moves = new List<DanceMove>();
            var toOptimize = new List<DanceMove>();
            for (int i = 0; i < danceMovesList.Count(); i++)
            {
                var move = danceMovesList[i];
                if (move.Type == DanceType.Partner)
                {
                    if (toOptimize.Count() > 0)
                    {
                        var flattened = new FlattenedMove(toOptimize, programs.Count());
                        moves.Add(flattened);
                        toOptimize = new List<DanceMove>();
                    }
                    moves.Add(move);
                }
                else
                {
                    toOptimize.Add(move);
                }

                if (i == danceMovesList.Count - 1 && move.Type != DanceType.Partner)
                {
                    var flattened = new FlattenedMove(toOptimize, programs.Count());
                    moves.Add(flattened);
                    toOptimize = new List<DanceMove>();
                }
            }

            return RemoveRedundantPartners(moves);
        }

        private List<DanceMove> RemoveRedundantPartners(List<DanceMove> moves)
        {
            var swappings = new Dictionary<string, int>();
            var nonP = moves.Where(m => m.Type != DanceType.Partner);
            var p = new List<DanceMove>();
            var partnerMoves = moves.Where(m => m.Type == DanceType.Partner).ToList();

            var manyPartnerMove = new ManyPartnerMove(partnerMoves.ToList(), programs.Count());
            return new List<DanceMove> { nonP.Single(), manyPartnerMove };
        }
    }
}