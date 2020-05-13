using System.Numerics;

namespace LeetCode
{
    public partial class Solution
    {
        // TODO: Handle num.Length > 1000. Using BigInteger causes timeouts
        public string RemoveKdigits(string num, int k)
        {
            if (!int.TryParse(num, out var parsedNum))
                return num;
            if (parsedNum == 0 || k >= num.Length)
                return "0";

            return RemoveKdigits_Recurse(num, k, parsedNum).ToString();
        }

        private int RemoveKdigits_Recurse(string num, int k, int currentMin)
        {
            if (k < 1)
                return currentMin;
            
            k -= 1;

            for (var i = 0; i < num.Length; i++)
            {
                var newNum = int.Parse(num.Remove(i, 1));

                if (newNum < currentMin)
                    currentMin = newNum;

                if (k > 0)
                {
                    var recursedNum = RemoveKdigits_Recurse(newNum.ToString(), k, currentMin);

                    if (recursedNum < currentMin)
                        currentMin = recursedNum;
                }
            }

            return currentMin;
        }
    }
}