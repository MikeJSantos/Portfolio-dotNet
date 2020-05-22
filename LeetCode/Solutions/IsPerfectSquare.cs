using Xunit;

namespace LeetCode
{
    public partial class Solution
    {
        public bool IsPerfectSquare(int num)
        {
            if (num < 1)
                return false;

            var numStr = num.ToString();

            if (numStr.Length % 2 == 1)
                numStr = "0" + numStr;

            int remainder = 0, largestN, previousLargestN = 1, calculation;

            for (var i = 0; i < numStr.Length / 2; i ++)
            {
                var partialNumStr = remainder.ToString() + numStr.Substring(i*2, 2);
                var partialNum = int.Parse(partialNumStr);

                if (partialNum == 0)
                    break;

                for (var j = 1; j <= 10; j++)
                {
                    calculation = (j == 1)
                        ? calculation = j * j
                        : (previousLargestN * previousLargestN * 10) * j * j;

                    if (calculation == partialNum)
                    {
                        largestN = j;
                        break;
                    }
                        
                    else if (calculation > partialNum)
                    {
                        largestN = j - 1;
                        remainder = partialNum - (largestN * largestN);
                        break;
                    }
                }
            }

            return remainder == 0;
        }
    }

    public partial class UnitTests
    {
        [Fact]
        public void IsPerfectSquareTest()
        {
            var s = new Solution();

            Assert.True(s.IsPerfectSquare(1));
            Assert.False(s.IsPerfectSquare(7));
            Assert.True(s.IsPerfectSquare(9));
            Assert.True(s.IsPerfectSquare(16));
            Assert.False(s.IsPerfectSquare(2147483647));
            // Failed test case.
            Assert.True(s.IsPerfectSquare(808201));
        }
    }
}