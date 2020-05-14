using System;
using System.Collections.Generic;

namespace LeetCode
{
    // TODO: Optimize. Runtime: 1384 ms (avg 216 ms), Memory Usage: 58.8 MB
    public class Trie
    {
        TrieNode root;

        public Trie()
        {
            root = new TrieNode();
        }

        public void Insert(string word)
        {
            string partialWord;
            var currentNode = root;

            for (var i = 0; i < word.Length; i++)
            {
                partialWord = word.Substring(0, i+1);

                if (currentNode.children.ContainsKey(partialWord))
                    currentNode = currentNode.children[partialWord];
                else
                {
                    var newNode = new TrieNode(partialWord);
                    currentNode.children[partialWord] = newNode;
                    currentNode = newNode;
                }
            }

            currentNode.count++;
        }

        public bool Search(string word)
        {
            return Find(word, true);
        }

        public bool StartsWith(string prefix)
        {
            return Find(prefix);
        }

        private bool Find(string word, bool isFullSearch = false)
        {
            if (root == null) return false;

            string partialWord;
            var currentNode = root;

            for (var i = 0; i < word.Length; i++)
            {
                partialWord = word.Substring(0, i+1);

                if (!currentNode.children.ContainsKey(partialWord))
                    return false;

                currentNode = currentNode.children[partialWord];
            }
            
            return isFullSearch
                ? currentNode.count > 0
                : true;
        }

        class TrieNode
        {
            public string val;
            public int count;
            public Dictionary<string, TrieNode> children;

            public TrieNode()
            {
                children = new Dictionary<string, TrieNode>();    
            }

            public TrieNode(string val) : this()
            {
                this.val = val;
            }

            public override string ToString()
            {
                return $"{val}: [{string.Join(',', children.Keys)}]";
            }
        }
    }
}