using System.Collections.Generic;

namespace LeetCode
{
    public partial class Solution
    {
        // TODO: Optimize. Runtime beats 26.95% of submissions. Runtime: 316 ms, Memory Usage: 35.7 MB
        public IList<int> FindAnagrams(string s, string p)
        {
            var startIndices = new List<int>();

            if (s.Length == 0 || p.Length == 0 || p.Length > s.Length)
                return startIndices;

            var pDict = new Dictionary<char, int>();
            foreach (var c in p.ToCharArray())
            {
                if (pDict.ContainsKey(c))
                    pDict[c] = pDict[c] + 1;
                else
                    pDict[c] = 1;
            }
        
            var subStringDict = new Dictionary<char, int>();
            for (var i = 0; i <= s.Length - p.Length; i++)
            {
                if (i == 0)
                {   // initialize substring dictionary
                    var substringArr = s.Substring(0, p.Length).ToCharArray();
                    foreach (var c in substringArr)
                    {
                        if (subStringDict.ContainsKey(c))
                            subStringDict[c] = subStringDict[c] + 1;
                        else
                            subStringDict[c] = 1;
                    }
                }
                else
                {   // remove s[i-1] from dictionary, add s[i+p.length-1]
                    var c = s[i-1];
                    if (subStringDict[c] == 1)
                        subStringDict.Remove(c);
                    else
                        subStringDict[c] = subStringDict[c] - 1;

                    c = s[i+p.Length-1];
                    if (!subStringDict.ContainsKey(c))
                        subStringDict[c] = 1;
                    else
                        subStringDict[c] = subStringDict[c] + 1;
                }

                // compare dictionaries
                var areDictionariesEqual = true;
                if (pDict.Count != subStringDict.Count)
                    areDictionariesEqual = false;
                else
                {
                    foreach (var kvp in pDict)
                    {
                        if (!subStringDict.ContainsKey(kvp.Key) || subStringDict[kvp.Key] != kvp.Value)
                        {
                            areDictionariesEqual = false;
                            break;
                        }
                    }
                }

                if (areDictionariesEqual)
                    startIndices.Add(i);
            }

            return startIndices;
        }
    }
}