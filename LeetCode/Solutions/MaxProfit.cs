using System;
using System.Linq;
using System.Collections.Generic;

namespace LeetCode
{
    public partial class Solution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length < 2) return 0;

            Console.Out.WriteLine($"[{string.Join(",", prices)}]");

            var optimalBuyDate = -1;
            var totalProfit = 0;

            for (var i = 0; i < prices.Length - 1; i++)
            {
                // Find optimal buy date, in cases where prices are falling
                if (optimalBuyDate == -1 || prices[i] < prices[optimalBuyDate])
                {
                    optimalBuyDate = i;
                    if (i + 1 < prices.Length - 1) continue;
                }

                var buyPrice = prices[optimalBuyDate];
                var optimalProfitToDayRatio = 0d;
                var optimalSellDate = -1;

                for (var sellDate = i; sellDate < prices.Length; sellDate++)
                {
                    var sellPrice = prices[sellDate];

                    // Ignore dates that don't turn a profit
                    if (buyPrice >= sellPrice)
                        continue;

                    var profit = sellPrice - buyPrice;
                    var daysOnMarket = sellDate - optimalBuyDate;
                    var profitToDayRatio = (double)profit / daysOnMarket;

                    if (optimalSellDate == -1 || profitToDayRatio >= optimalProfitToDayRatio && profit > prices[optimalSellDate] - buyPrice)
                    {
                        optimalProfitToDayRatio = profitToDayRatio;
                        optimalSellDate = sellDate;
                    }
                }

                if (optimalSellDate != -1)
                {
                    var transactionProfit = prices[optimalSellDate] - buyPrice;
                    totalProfit += transactionProfit;
                    Console.Out.WriteLine($"- Profit: {transactionProfit}, Buy day {optimalBuyDate} @ {prices[optimalBuyDate]}, " +
                                          $"Sell day {optimalSellDate} @ {prices[optimalSellDate]}");
                    optimalBuyDate = -1;
                    i = optimalSellDate;
                }
            }

            Console.Out.WriteLine($"Total Profit: {totalProfit}");
            return totalProfit;
        }
    }
}