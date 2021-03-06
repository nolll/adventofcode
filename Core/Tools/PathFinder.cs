using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Tools
{
    public static class PathFinder
    {
        public static int StepCountTo(Matrix<char> matrix, MatrixAddress from, MatrixAddress to)
        {
            var coordCounts = GetCoordCounts(matrix, from, to);
            var goal = coordCounts.FirstOrDefault(o => o.X == from.X && o.Y == from.Y);
            return goal?.Count ?? 0;
        }

        public static IList<MatrixAddress> ShortestPathTo(Matrix<char> matrix, MatrixAddress from, MatrixAddress to)
        {
            var coordCounts = GetCoordCounts(matrix, from, to);
            var pathMatrix = new Matrix<int>(matrix.Width, matrix.Height, -1);
            foreach (var coordCount in coordCounts)
            {
                pathMatrix.MoveTo(coordCount.X, coordCount.Y);
                pathMatrix.WriteValue(coordCount.Count);
            }

            var path = new List<MatrixAddress>();
            var currentAddress = from;
            while (!currentAddress.Equals(to))
            {
                pathMatrix.MoveTo(currentAddress);
                var adjacentCoords = pathMatrix.PerpendicularAdjacentCoords
                    .Where(o => pathMatrix.ReadValueAt(o) > -1)
                    .OrderBy(o => pathMatrix.ReadValueAt(o))
                    .ThenBy(o => o.Y)
                    .ThenBy(o => o.X)
                    .ToList();
                var bestAddress = adjacentCoords.FirstOrDefault();
                if (bestAddress == null)
                    break;
                currentAddress = new MatrixAddress(bestAddress.X, bestAddress.Y);
                path.Add(currentAddress);
            }

            return path;
        }

        private static IList<CoordCount> GetCoordCounts(Matrix<char> matrix, MatrixAddress from, MatrixAddress to)
        {
            var queue = new List<CoordCount> { new CoordCount(to.X, to.Y, 0) };
            var index = 0;
            while (index < queue.Count && !queue.Any(o => o.X == from.X && o.Y == from.Y))
            {
                var next = queue[index];
                matrix.MoveTo(next.X, next.Y);
                var adjacentCoords = matrix.PerpendicularAdjacentCoords
                    .Where(o => matrix.ReadValueAt(o) == '.' && !queue.Any(q => q.X == o.X && q.Y == o.Y))
                    .ToList();
                var newCoordCounts = adjacentCoords.Select(o => new CoordCount(o.X, o.Y, next.Count + 1));
                queue.AddRange(newCoordCounts);
                index++;
            }

            return queue;
        }
    }

    public class CoordCount
    {
        public int X { get; }
        public int Y { get; }
        public int Count { get; }

        public CoordCount(int x, int y, int count)
        {
            X = x;
            Y = y;
            Count = count;
        }
    }
}