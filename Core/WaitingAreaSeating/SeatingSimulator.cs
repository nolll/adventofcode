using System.Collections.Generic;
using System.Linq;
using Core.Tools;

namespace Core.WaitingAreaSeating
{
    public abstract class SeatingSimulator
    {
        protected const char Floor = '.';
        protected const char OccupiedChair = '#';
        protected const char EmptyChair = 'L';

        protected Matrix<char> Matrix;
        public int OccupiedSeatCount { get; private set; }

        protected SeatingSimulator(string input)
        {
            Matrix = MatrixBuilder.BuildCharMatrix(input);
        }

        public void Run()
        {
            var prevCount = 0;
            var currentCount = -1;
            while (prevCount != currentCount)
            {
                prevCount = currentCount;
                RunOnce();
                currentCount = Matrix.Values.Count(o => o == OccupiedChair);
            }

            OccupiedSeatCount = currentCount;
        }

        private void RunOnce()
        {
            var newMatrix = Matrix.Copy();
            for (var y = 0; y < Matrix.Height; y++)
            {
                for (var x = 0; x < Matrix.Width; x++)
                {
                    Matrix.MoveTo(x, y);
                    var currentValue = Matrix.ReadValue();
                    var adjacentValues = GetAdjacentSeats();
                    var neighborCount = adjacentValues.Count(o => o == OccupiedChair);
                    var newValue = GetSeatStatus(currentValue, neighborCount);

                    newMatrix.MoveTo(x, y);
                    newMatrix.WriteValue(newValue);
                }
            }
            Matrix = newMatrix;
        }

        protected abstract IList<char> GetAdjacentSeats();
        protected abstract char GetSeatStatus(char currentValue, int neighborCount);
    }
}