using System;
using System.Linq;
using System.Collections.Generic;

namespace LeetCode
{
    public class MaxProfit
    {
        // Input: [7,1,5,3,6,4]
        // Output: 7
        // Explanation: Buy on day 2 (price = 1) and sell on day 3 (price = 5), profit = 5-1 = 4.
        //              Then buy on day 4 (price = 3) and sell on day 5 (price = 6), profit = 6-3 = 3.
        public int Run(int[] prices)
        {
            if (prices.Length < 2) return 0;

            var buyDate = 0;
            var sellDate = -1;
            var previousProfit = -1;

            for (var i = 1; i < prices.Length; i++)
            {
                if (prices[i] < prices[buyDate]) // TODO: factor in sell date
                {
                    buyDate = i;
                }
                else
                {
                    var profit = prices[i];
                    for (var j = i-1; j > buyDate; j--)
                    {
                        
                    }
                }
                
            }


            throw new NotImplementedException();
        }
    }
}