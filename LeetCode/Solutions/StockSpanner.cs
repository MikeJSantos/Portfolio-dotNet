using System.Linq;
using System.Collections.Generic;
using Xunit;

namespace LeetCode
{
    public class StockSpanner
    {
        private List<int> _prices;

        public StockSpanner()
        {
            _prices = new List<int>();
        }

        public int Next(int price)
        {
            _prices.Add(price);

            if (_prices.Count() == 1)
                return 1;

            int span        = 1,
                todaysPrice = _prices.Last();
            var isFirstConsecutiveDay = true;

            for (var i = _prices.Count() - 1; i >= 0; i--)
            {
                if (_prices[i] <= todaysPrice)
                {
                    if (isFirstConsecutiveDay)
                        isFirstConsecutiveDay = false;
                    else
                        span++;
                }
                else
                    break;
            }

            return span;
        }
    }

    public partial class UnitTests
    {
        [Fact]
        public void StockSpannerTest()
        {
            var ss = new StockSpanner();

            Assert.Equal(1, ss.Next(100));
            Assert.Equal(1, ss.Next(80));
            Assert.Equal(1, ss.Next(60));
            Assert.Equal(2, ss.Next(70));
            Assert.Equal(1, ss.Next(60));
            Assert.Equal(4, ss.Next(75));
            Assert.Equal(6, ss.Next(85));

            ss = new StockSpanner(); // 2/99
            Assert.Equal(1, ss.Next(31));
            Assert.Equal(2, ss.Next(41));
            Assert.Equal(3, ss.Next(48));
            Assert.Equal(4, ss.Next(59));
            Assert.Equal(5, ss.Next(79));

            ss = new StockSpanner(); // 27/99
            Assert.Equal(1, ss.Next(32));
            Assert.Equal(2, ss.Next(82));
            Assert.Equal(1, ss.Next(73));
            Assert.Equal(4, ss.Next(99));
            Assert.Equal(1, ss.Next(91));
        }
    }
}
