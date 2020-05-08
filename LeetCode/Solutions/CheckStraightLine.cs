
namespace LeetCode
{
    public partial class Solution
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            if (coordinates == null || coordinates.GetLength(0) < 2)
                return false;

            int rise = 0, run = 0;
            double slope = double.MinValue, initialSlope = double.MinValue;

            for (var row = 1; row < coordinates.GetLength(0); row++)
            {
                if (coordinates[row].Length < 2)
                    return false;

                rise  = coordinates[row][1] - coordinates[row-1][1];
                run   = coordinates[row][0] - coordinates[row-1][0];
                slope = (double) rise / run;

                if (row == 1)
                    initialSlope = slope;
                else if (slope != initialSlope)
                    return false;
            }

            return true;
        }
    }
}