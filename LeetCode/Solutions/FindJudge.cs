using System;
using System.Linq;
using System.Collections.Generic;

namespace LeetCode
{
    public partial class Solution
    {
        // TODO: Optimize. 836ms runtime, 300ms average
        public int FindJudge(int N, int[][] trust)
        {
            if (N == 1) return 1;
            if (N < 1 || trust.Length == 0) return -1;

            var trustDictionary = new Dictionary<int, int>();
            var cannotBeAJudge = new List<int>();

            for (int row = 0; row < trust.Length; row++)
            {
                var truster = trust[row][0];
                var trustee = trust[row][1];

                // 1. The town judge trusts nobody.
                if (!cannotBeAJudge.Contains(truster))
                {
                    cannotBeAJudge.Add(truster);
                    if (trustDictionary.ContainsKey(truster))
                        trustDictionary.Remove(truster);
                }

                if (!cannotBeAJudge.Contains(trustee))
                {
                    trustDictionary[trustee] = trustDictionary.ContainsKey(trustee)
                        ? trustDictionary[trustee] + 1
                        : 1;
                }
            }

            if (!trustDictionary.Any())
                return -1;

            var maxTrust = trustDictionary.Values.Max();

            // 2. Everybody (except for the town judge) trusts the town judge.
            // 3. There is exactly one person that satisfies properties 1 and 2.
            if (maxTrust != N - 1 || trustDictionary.Values.Count(v => v == maxTrust) > 1)
                return -1;

            return trustDictionary.First(v => v.Value == maxTrust).Key;
        }
    }
}