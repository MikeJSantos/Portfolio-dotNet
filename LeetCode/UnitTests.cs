using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace LeetCode
{
    public partial class UnitTests
    {
        private string ReadTestDataFromFile(string fileName)
        {
            var basePath = @"C:\Projects\Portfolio-dotNet\LeetCode\TestData";

            var path = Path.Combine(basePath, fileName);
            using (var sr = new StreamReader(path))
            {
                return sr.ReadToEnd();
            }
        }

        [Fact]
        public void RemoveKdigitsTest()
        {
            var s = new Solution();
            int k;
            string num, output;

            num = "1432219";
            k = 3;
            output = "1219";
            Assert.Equal(output, s.RemoveKdigits(num, k));

            num = "10200";
            k = 1;
            output = "200";
            Assert.Equal(output, s.RemoveKdigits(num, k));

            num = "10";
            k = 2;
            output = "0";
            Assert.Equal(output, s.RemoveKdigits(num, k));

            num = "0";
            k = 0;
            output = "0";
            Assert.Equal(output, s.RemoveKdigits(num, k));

            num = "12345";
            k = 0;
            output = num;
            Assert.Equal(output, s.RemoveKdigits(num, k));

            // TODO: Failed test case. Length 10,001 > 8899
            num = ReadTestDataFromFile("RemoveKdigits_input.txt");
            k = 1000;
            output = ReadTestDataFromFile("RemoveKdigits_output.txt");
            Assert.Equal(output, s.RemoveKdigits(num, k));
        }
        
        [Fact]
        public void CheckInclusionTest()
        {
            var s = new Solution();
            string s1, s2;

            s1 = "ab";
            s2 = "eidbaooo";
            Assert.True(s.CheckInclusion(s1, s2));

            s1 = "ab";
            s2 = "eidboaoo";
            Assert.False(s.CheckInclusion(s1, s2));

            s1 = "adc";
            s2 = "dcda";
            Assert.True(s.CheckInclusion(s1, s2));

            s1 = "hello";
            s2 = "ooolleoooleh";
            Assert.False(s.CheckInclusion(s1, s2));
        }

        [Fact]
        public void FindAnagramsTest()
        {
            var s = new Solution();
            string str, p;
            IList<int> expected;

            str = "cbaebabacd";
            p = "abc";
            expected = new List<int>() { 0, 6 };
            Assert.Equal(expected, s.FindAnagrams(str,p));

            str = "abab";
            p = "ab";
            expected = new List<int>() { 0, 1, 2 };
            Assert.Equal(expected, s.FindAnagrams(str,p));
        }
    }
}