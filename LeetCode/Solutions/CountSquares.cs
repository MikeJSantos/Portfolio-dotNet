using System;
using Xunit;

namespace LeetCode
{
    public partial class Solution
    {
        public int CountSquares(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0)
                return 0;

            int totalSquares = 0, maxSide;

            // 3rd dimension is the side minus 1 (ex: 0 is 1x1, 1 is 2x2, 2 is 3x3)
            bool[,,] squaresArray = new bool[matrix.Length, matrix[0].Length, Math.Min(matrix.Length, matrix[0].Length)];
            
            // TODO: How do we handle jagged arrays?
            for (var row = 0; row < matrix.Length; row++)
                for (var col = 0; col < matrix[row].Length; col++)
                {
                    maxSide = Math.Min(matrix.Length - row, matrix[row].Length - col);
                    CountSquares_SubarrayCheck(matrix, row, col, maxSide, squaresArray, ref totalSquares);
                }

            return totalSquares;
        }

        private void CountSquares_SubarrayCheck(int[][] matrix, int startRow, int startCol, int maxSide, bool[,,] squaresArray, ref int totalSquares)
        {
            if (matrix[startRow][startCol] != 1)
                return;

            if (maxSide == 1 )
            {
                squaresArray[startRow, startCol, 0] = true;
                totalSquares++;
                System.Console.WriteLine($"1x1 square at [{startRow},{startCol}]");
                return;
            }

            for (var side = 2; side <= maxSide; side++)
            {
                // If a 3x3 array at [0,0] exists, then a 2x2 array at [1,1] exists
                if (startRow - 1 >= 0 &&
                    startCol - 1 >= 0 && 
                    side + 1 <= maxSide &&
                    squaresArray[startRow - 1, startCol - 1, side + 1])
                {
                    squaresArray[startRow, startCol, side - 1] = true;
                    System.Console.WriteLine($"{side}x{side} square at [{startRow},{startCol}] based on {side+1}x{side+1} square at [{startRow-1},{startCol-1}]");
                    totalSquares++;
                    continue;
                }

                // Manually check side x side array at [startRow, startCol]
                var isSquare = true;
                for (var row = startRow; row < startRow + side; row++)
                    for (var col = startCol; col < startCol + side; col++)
                        if (matrix[row][col] != 1)
                        {
                            isSquare = false;
                            break;
                        }

                if (isSquare)
                {
                    squaresArray[startRow, startCol, side - 1] = true;
                    System.Console.WriteLine($"{side}x{side}} square at [{startRow},{startCol}] based on manual check");
                    totalSquares++;
                }
            }
        }
    }

    public partial class UnitTests
    {
        [Fact]
        public void CountSquaresTest()
        {
            var s = new Solution();
            int[][] matrix;
            int expected;

            matrix = new int[][] {
                new int [] {0,1,1,1},
                new int [] {1,1,1,1},
                new int [] {0,1,1,1}
            };
            expected = 15; // 10 (1), 4 (2), 1 (3)
            Assert.Equal(expected, s.CountSquares(matrix));

            matrix = new int[][] {
                new int [] {1,0,1},
                new int [] {1,1,0},
                new int [] {1,1,0}
            };
            expected = 7; // 6 (1), 1 (2)
            Assert.Equal(expected, s.CountSquares(matrix));
        }
    }
}