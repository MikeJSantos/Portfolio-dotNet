using System;

namespace LeetCode
{
    public partial class Solution
    {
        // TODO: Optimize. Time Limit Exceeded on "2147483647"
        public bool IsPerfectSquare(int num)
        {
            if (num < 1) return false;

            long currentGuess = num / 2;

            while (true)
            {
                long square = currentGuess * currentGuess;

                if (square == num)
                    return true;
    
                long lowerBound = currentGuess / 2;
                long upperBound = Convert.ToInt64(currentGuess * 1.5);

                if (square > num)
                    currentGuess = lowerBound;
                else if (square < num)
                    currentGuess = upperBound;
                else if (upperBound == lowerBound)
                    return lowerBound * lowerBound == num;
            }
        }
    }
}