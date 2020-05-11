using System;

namespace LeetCode
{
    public partial class Solution
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            if (!FloodFill_IsCoordinateValid(image, sr, sc) || !FloodFill_IsColorValid(newColor))
                return image;

            var matchColor = image[sr][sc];

            if (!FloodFill_IsColorValid(matchColor) || matchColor == newColor)
                return image;

            FloodFill_Recurse(image, sr, sc, matchColor, newColor);

            return image;
        }

        private void FloodFill_Recurse(int[][] image, int row, int col, int matchColor, int newColor)
        {
            if (!FloodFill_IsCoordinateValid(image, row, col)) return;

            if (image[row][col] == matchColor)
            {
                image[row][col] = newColor;
                FloodFill_Recurse(image, row-1, col, matchColor, newColor);
                FloodFill_Recurse(image, row+1, col, matchColor, newColor);
                FloodFill_Recurse(image, row, col-1, matchColor, newColor);
                FloodFill_Recurse(image, row, col+1, matchColor, newColor);
            }
        }

        private bool FloodFill_IsCoordinateValid(int[][] image, int row, int col)
        {
            return row >= 0 && row < image.Length && col >= 0 && col < image[row].Length;
        }

        private bool FloodFill_IsColorValid(int color)
        {
            return color >= 0 && color <= 65535;
        }
    }
}