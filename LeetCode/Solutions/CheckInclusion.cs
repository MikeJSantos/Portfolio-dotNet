using System;
using System.Linq;
using System.Collections.Generic;

namespace LeetCode
{
    public partial class Solution
    {
        // TODO: Optimize? Runtime: 2248 ms Memory Usage: 26.6 MB (Avg Runtime 26 ms?!)
        public bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length < 1 || s2.Length < 1)
                return false;

            var sourceDict = new Dictionary<char, int>();

            for (var i = 0; i < s1.Length; i++)
            {
                var c = s1[i];
                sourceDict[c] = sourceDict.ContainsKey(c)
                    ? sourceDict[c] + 1
                    : 1;
            }

            for (var i = 0; i <= s2.Length - s1.Length; i++)
            {
                var dict = new Dictionary<char, int>(sourceDict);
                var charArray = s2.Substring(i, s1.Length).ToCharArray();

                foreach (var c in charArray)
                {
                    if (dict.ContainsKey(c))
                    {
                        if (dict[c] == 1)
                        {
                            dict.Remove(c);

                            if (!dict.Keys.Any())
                                return true;
                        }
                        else
                            dict[c] = dict[c] - 1;
                    }
                    else
                        break;
                }
            }

            return false;
        }
    }
}