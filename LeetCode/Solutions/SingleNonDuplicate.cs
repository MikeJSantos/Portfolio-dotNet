using System.Linq;
using System.Collections.Generic;

namespace LeetCode
{
    public partial class Solution
    {
        // Beats 73.78% of submissions
        public int SingleNonDuplicate(int[] nums)
        {
            var dict = new Dictionary<int, bool>();

            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                    dict.Remove(num);
                else
                    dict[num] = true;
            }

            return dict.Keys.FirstOrDefault();
        }
    }
}