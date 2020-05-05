using System;
using System.Linq;
using System.Collections.Generic;

namespace LeetCode
{
    public partial class Solution
    {
        public int NumJewelsInStones(string J, string S) {
            var jewelCount = 0;
            var jewels = J.ToCharArray();

            foreach(var stone in S.ToCharArray())
            {
                if (jewels.Contains(stone))
                    jewelCount++;
            }

            return jewelCount;
        }
    }
}