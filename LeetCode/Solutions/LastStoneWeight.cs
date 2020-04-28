using System;
using System.Linq;
using System.Collections.Generic;

namespace LeetCode
{
    public partial class Solution
    {
        public int LastStoneWeight(int[] stones)
        {
            if (stones.Length == 0) return 0;
            if (stones.Length == 1) return stones[0];
            
            var sortedStones = new List<int>(stones);
            sortedStones.Sort();

            while (sortedStones.Count > 1)
            {   
                // Remove last 2 stones from list & smash to get new stone
                var stoneA = sortedStones.Last();
                var stoneB = sortedStones[sortedStones.Count - 2];
                var smashedStone = stoneA - stoneB;
                sortedStones.RemoveRange(sortedStones.Count - 2, 2);

                if (smashedStone == 0)
                    continue;

                // Last stone left
                if (!sortedStones.Any())
                    return smashedStone;

                if (smashedStone >= sortedStones.Last())
                {   // Insert at end
                    sortedStones.Add(smashedStone);
                }
                else
                {   // Reinsert the new stone in order
                    for (var i = 0; i < sortedStones.Count; i++)
                    {
                        if (smashedStone <= sortedStones[i])
                        {
                            sortedStones.Insert(i, smashedStone);
                            break;
                        }
                    }
                }
            } // while

            return sortedStones.FirstOrDefault();
        }
    }
}