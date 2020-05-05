using System;
using System.Linq;
using System.Collections.Generic;

namespace LeetCode
{
    public partial class Solution
    {
        // TODO: Optimize. Slower than 74% of submissions. Sort both strings, then compare chunks of the ransom note to magazine?
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var noteDictionary = new Dictionary<char, int>();
            var magDictionary = new Dictionary<char, int>();

            foreach (var c in ransomNote.ToCharArray())
            {
                if (c == ' ') continue;
                noteDictionary[c] = noteDictionary.ContainsKey(c)
                    ? noteDictionary[c] + 1
                    : 1;
            }

            foreach (var c in magazine.ToCharArray())
            {
                if (c == ' ') continue;
                magDictionary[c] = magDictionary.ContainsKey(c)
                    ? magDictionary[c] + 1
                    : 1;
            }

            foreach(var c in noteDictionary.Keys)
            {
                if (!magDictionary.ContainsKey(c) || magDictionary[c] < noteDictionary[c]) return false;
            }

            return true;
        }
    }
}