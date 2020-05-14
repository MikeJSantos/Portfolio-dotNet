using System.Numerics;

namespace LeetCode
{
    public partial class Solution
    {
        private int getMinStringIter = 0;

        public string RemoveKdigits(string num, int k)
        {
            if (!BigInteger.TryParse(num, out var parsedNum))
                return num;
            if (parsedNum == 0 || k >= num.Length)
                return "0";

            return RemoveKdigits_Recurse(num.TrimStart('0'), k, num);
        }

        private string RemoveKdigits_Recurse(string num, int k, string currentMin)
        {
            if (k < 1)
                return currentMin;

            k -= 1;

            for (var i = 0; i < num.Length; i++)
            {
                var newNumStr = num.Remove(i, 1);
                
                if (newNumStr.StartsWith('0'))
                    newNumStr = newNumStr.TrimStart('0');

                if (k > 0)
                {
                    var recursedNum = RemoveKdigits_Recurse(newNumStr, k, currentMin);
                    currentMin = recursedNum;
                }
                else
                {
                    currentMin = RemoveKdigits_GetMinString(currentMin, newNumStr);
                }
            }

            return currentMin;
        }

        private string RemoveKdigits_GetMinString(string str1, string str2)
        {
            getMinStringIter++;
            if (getMinStringIter % 1000 == 0)
                System.Console.WriteLine($"GetMinString: {getMinStringIter}");

            if (str1 == str2)
                return str1;
            else if (str1.Length < str2.Length)
                return str1;
            else if (str2.Length < str1.Length)
                return str2;
            
            for (var i = 0; i < str1.Length; i++)
            {
                if (str1[i] < str2[i])
                    return str1;
                else if (str2[i] < str1[i])
                    return str2;
            }

            return str1; // Redundant, shouldn't reach this code
        }
    }
}