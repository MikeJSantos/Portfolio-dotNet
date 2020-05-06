using System.Linq;
using System.Collections.Generic;

namespace LeetCode
{
    public partial class Solution
    {
        // TODO: Optimize. Beats 42.72% of submissions
        public int MajorityElement(int[] nums)
        {
            var majorityElement = 0;
            var numDictionary = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (!numDictionary.Any())
                {
                    numDictionary[num] = 1;
                    majorityElement = num;
                    continue;
                }

                numDictionary[num] = numDictionary.ContainsKey(num)
                    ? numDictionary[num] + 1
                    : 1;

                if (numDictionary[num] > numDictionary[majorityElement])
                    majorityElement = num;
            }

            return majorityElement;
        }
    }
}