using System.IO;
using Xunit;

namespace LeetCode
{
    public class UnitTests
    {
        [Fact]
        public void CountElementsTest()
        {
            var s = new Solution();
            int[] arr;

            arr = new int[] { 1, 2, 3 }; // 2
            Assert.Equal(2, s.CountElements(arr));

            arr = new int[] { 1, 1, 3, 3, 5, 5, 7, 7 }; // 0
            Assert.Equal(0, s.CountElements(arr));

            arr = new int[] { 1, 3, 2, 3, 5, 0 }; // 3
            Assert.Equal(3, s.CountElements(arr));

            arr = new int[] { 1, 1, 1, 1, 2, 2 }; // 4
            Assert.Equal(4, s.CountElements(arr));
        }

        [Fact]
        public void MaxProfitTest()
        {
            var s = new Solution();
            int[] intArray;

            intArray = new int[] { 7, 1, 5, 3, 6, 4 }; // 7
            Assert.Equal(7, s.MaxProfit(intArray));

            intArray = new int[] { 1, 2, 3, 4, 5 }; // 4
            Assert.Equal(4, s.MaxProfit(intArray));

            intArray = new int[] { 7, 6, 4, 3, 1 }; // 0
            Assert.Equal(0, s.MaxProfit(intArray));

            intArray = new int[] { 1, 2 }; // 1
            Assert.Equal(1, s.MaxProfit(intArray));

            intArray = new int[] { 2, 1, 4, 5, 2, 9, 7 }; // 11
            Assert.Equal(11, s.MaxProfit(intArray));
            // TODO: Fix this!
        }

        [Fact]
        public void MiddleNodeTest()
        {
            var s = new Solution();
            ListNode node;

            node = ListNode.Build(new int[] { 1, 2, 3, 4, 5 });
            Assert.Equal(3, s.MiddleNode(node).val);

            node = ListNode.Build(new int[] { 1, 2, 3, 4, 5, 6 });
            Assert.Equal(4, s.MiddleNode(node).val);
        }

        [Fact]
        public void MinStackTest()
        {
            var minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            Assert.Equal(-3, minStack.GetMin());

            minStack.Pop();
            Assert.Equal(0, minStack.Top());
            Assert.Equal(-2, minStack.GetMin());
        }

        [Fact]
        public void LastStoneWeightTest()
        {
            var s = new Solution();
            int[] stones;

            stones = new int[] { 2, 7, 4, 1, 8, 1 };
            Assert.Equal(1, s.LastStoneWeight(stones));

            stones = new int[] { 7, 6, 7, 6, 9 };
            Assert.Equal(3, s.LastStoneWeight(stones));
        }

        [Fact]
        public void BackspaceCompareTest()
        {
            var s = new Solution();
            Assert.True(s.BackspaceCompare("ab#c", "ad#c")); // true, "ac"
            Assert.True(s.BackspaceCompare("ab##", "c#d#")); // true, ""
            Assert.True(s.BackspaceCompare("a##c", "#a#c")); // true, "c"
            Assert.False(s.BackspaceCompare("a#c", "b"));    // false, "c" > "b"
        }

        [Fact]
        public void StringShiftTest()
        {
            var s = new Solution();
            string inputStr;
            int[][] shift;

            inputStr = "abc";
            shift = new int[][] { new int[] { 0, 1 }, new int[] { 1, 2 } };
            Assert.Equal("cab", s.StringShift(inputStr, shift));

            inputStr = "abcdefg";
            shift = new int[][] { new int[] { 1, 1 }, new int[] { 1, 1 }, new int[] { 0, 2 }, new int[] { 1, 3 } };
            Assert.Equal("efgabcd", s.StringShift(inputStr, shift));
        }

        [Fact]
        public void DiameterOfBinaryTreeTest()
        {
            var s = new Solution();
            TreeNode head;

            var leftNode = new TreeNode(2, 4, 5);
            head = new TreeNode(1, leftNode, new TreeNode(3));
            Assert.Equal(3, s.DiameterOfBinaryTree(head));

            head = new TreeNode(1);
            Assert.Equal(0, s.DiameterOfBinaryTree(head));

            head = new TreeNode(1, new TreeNode(2), null);
            Assert.Equal(1, s.DiameterOfBinaryTree(head));

            // Input:
            // [4,-7,-3,null,null,-9,-3,9,-7,-4,null,6,null,-6,-6,null,null,0,6,5,null,9,null,null,-1,-4,null,null,null,-2]
            // Output:
            // 7
            // Expected:
            // 8
        }

        [Fact]
        public void FirstUniqCharacterTest()
        {
            var s = new Solution();
            string str;

            str = "leetcode";
            Assert.Equal(0, s.FirstUniqChar(str));

            str = "loveleetcode";
            Assert.Equal(2, s.FirstUniqChar(str));
        }

        [Fact]
        public void NumJewelsInStonesTest()
        {
            var s = new Solution();
            string J, S;

            J = "aA";
            S = "aAAbbbb";
            Assert.Equal(3, s.NumJewelsInStones(J, S));

            J = "z";
            S = "ZZ";
            Assert.Equal(0, s.NumJewelsInStones(J, S));
        }

        [Fact]
        public void CanConstructTest()
        {
            var s = new Solution();
            string ransomNote, magazine;

            ransomNote = "give me the money";
            magazine = "given all the memes that make money";
            Assert.True(s.CanConstruct(ransomNote, magazine));

            ransomNote = "a";
            magazine = "b";
            Assert.False(s.CanConstruct(ransomNote, magazine));

            ransomNote = "aa";
            magazine = "ab";
            Assert.False(s.CanConstruct(ransomNote, magazine));

            ransomNote = "aa";
            magazine = "aab";
            Assert.True(s.CanConstruct(ransomNote, magazine));
        }

        [Fact]
        public void FindComplementTest()
        {
            var s = new Solution();

            Assert.Equal(2, s.FindComplement(5));
            Assert.Equal(0, s.FindComplement(1));
        }

        [Fact]
        public void FirstBadVersionTest()
        {
            var s = new Solution();

            // Assert.Equal(4, s.FirstBadVersion(5));
            // Assert.Equal(3, s.FirstBadVersion(4));
            Assert.Equal(1150769282, s.FirstBadVersion(1420736637));
        }

        [Fact]
        public void MajorityElementTest()
        {
            var s = new Solution();
            int[] array;

            array = new int[] { 3, 2, 3 };
            Assert.Equal(3, s.MajorityElement(array));

            array = new int[] { 2, 2, 1, 1, 1, 2, 2 };
            Assert.Equal(2, s.MajorityElement(array));

            array = new int[] { 6, 5, 5 };
            Assert.Equal(5, s.MajorityElement(array));
        }

        [Fact]
        public void IsCousinsTest()
        {
            var s = new Solution();
            TreeNode root;
            int?[] array;

            array = new int?[] { 1, 2, 3, 4 };
            root = TreeNode.Build(array);
            Assert.False(s.IsCousins(root, 4, 3));

            array = new int?[] { 1, 2, 3, null, 4, null, 5 };
            root = TreeNode.Build(array);
            Assert.True(s.IsCousins(root, 5, 4));

            array = new int?[] { 1, 2, 3, null, 4 };
            root = TreeNode.Build(array);
            Assert.False(s.IsCousins(root, 2, 3));

            array = new int?[] { 1, 2, 3, null, null, null, 4, 5 };
            root = TreeNode.Build(array);
            Assert.False(s.IsCousins(root, 1, 2));
        }

        [Fact]
        public void CheckStraightLineTest()
        {
            var s = new Solution();
            int[][] coordinates;

            coordinates = new int[][] {
                new int[] {1,2},
                new int[] {2,3},
                new int[] {3,4},
                new int[] {4,5},
                new int[] {5,6},
                new int[] {6,7}
            };
            Assert.True(s.CheckStraightLine(coordinates));

            coordinates = new int[][] {
                new int[] {1,1},
                new int[] {2,2},
                new int[] {3,4},
                new int[] {4,5},
                new int[] {5,6},
                new int[] {7,7}
            };
            Assert.False(s.CheckStraightLine(coordinates));
        }

        [Fact]
        public void AddTwoNumbersTest()
        {
            var s = new Solution();
            ListNode l1, l2, expected;

            // l1       = ListNode.Build(new int[] { 2, 4, 3 });
            // l2       = ListNode.Build(new int[] { 5, 6, 4 });
            // expected = ListNode.Build(new int[] { 7, 0, 8 });
            // Assert.Equal(expected, s.AddTwoNumbers(l1, l2));

            // l1       = ListNode.Build(new int[] { 0 });
            // l2       = ListNode.Build(new int[] { 0 });
            // expected = ListNode.Build(new int[] { 0 });
            // Assert.Equal(expected, s.AddTwoNumbers(l1, l2));

            // l1       = ListNode.Build(new int[] { 0 });
            // l2       = ListNode.Build(new int[] { 1 });
            // expected = ListNode.Build(new int[] { 1 });
            // Assert.Equal(expected, s.AddTwoNumbers(l1, l2));

            // l1       = ListNode.Build(new int[] { 5 });
            // l2       = ListNode.Build(new int[] { 5 });
            // expected = ListNode.Build(new int[] { 0, 1 });
            // Assert.Equal(expected, s.AddTwoNumbers(l1, l2));

            // l1       = ListNode.Build(new int[] { 9 });
            // l2       = ListNode.Build(new int[] { 1, 9, 9, 9, 9, 9, 9, 9, 9, 9 });
            // expected = ListNode.Build(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 });
            // Assert.Equal(expected, s.AddTwoNumbers(l1, l2));

            l1 = ListNode.Build(new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 });
            l2 = ListNode.Build(new int[] { 5, 6, 4 });
            expected = ListNode.Build(new int[] { 6, 6, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 });
            Assert.Equal(expected, s.AddTwoNumbers(l1, l2));
        }

        [Fact]
        public void FindJudgeTest()
        {
            var s = new Solution();
            int[][] trust;

            trust = new int[][] {
                new int[] {1, 2}
            };
            Assert.Equal(2, s.FindJudge(2, trust));

            trust = new int[][] {
                new int[] {1, 3},
                new int[] {2, 3},
            };
            Assert.Equal(3, s.FindJudge(3, trust));

            trust = new int[][] {
                new int[] {1, 3},
                new int[] {2, 3},
                new int[] {3, 1},
            };
            Assert.Equal(-1, s.FindJudge(3, trust));

            trust = new int[][] {
                new int[] {1, 2},
                new int[] {2, 3},
            };
            Assert.Equal(-1, s.FindJudge(3, trust));

            trust = new int[][] {
                new int[] {1, 3},
                new int[] {1, 4},
                new int[] {2, 3},
                new int[] {2, 4},
                new int[] {4, 3}
            };
            Assert.Equal(3, s.FindJudge(4, trust));

            trust = new int[][] { };
            Assert.Equal(1, s.FindJudge(1, trust));

            trust = new int[][] {
                new int[] {1, 2},
                new int[] {3, 2},
                new int[] {1, 3},
                new int[] {4, 1},
                new int[] {3, 1},
                new int[] {2, 1},
                new int[] {2, 3},
                new int[] {4, 3},
                new int[] {4, 2},
                new int[] {3, 4},
                new int[] {2, 4}
            };
            Assert.Equal(-1, s.FindJudge(4, trust));
        }

        [Fact]
        public void FloodFillTest()
        {
            var s = new Solution();
            int[][] image, retVal;
            int sr, sc, newColor;

            image = new int[][] {
                new int[] {1,1,1},
                new int[] {1,1,0},
                new int[] {1,0,1}
            };
            sr = 1;
            sc = 1;
            newColor = 2;

            retVal = new int[][] {
                new int[] {2,2,2},
                new int[] {2,2,0},
                new int[] {2,0,1}
            };

            Assert.Equal(retVal, s.FloodFill(image, sr, sc, newColor));

            image = new int[][] {
                new int[] {0,0,0},
                new int[] {0,1,1},
            };
            sr = 1;
            sc = 1;
            newColor = 1;
            Assert.Equal(image, s.FloodFill(image, sr, sc, newColor));
        }

        [Fact]
        public void IsPerfectSquareTest()
        {
            var s = new Solution();

            Assert.True(s.IsPerfectSquare(16));
            Assert.False(s.IsPerfectSquare(2147483647));
        }

        [Fact]
        public void SingleNonDuplicateTest()
        {
            var s = new Solution();
            int[] nums;

            nums = new int[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 };
            Assert.Equal(2, s.SingleNonDuplicate(nums));

            nums = new int[] { 3, 3, 7, 7, 10, 11, 11 };
            Assert.Equal(10, s.SingleNonDuplicate(nums));
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

            // 10,001 > 8899

            var basePath = @"C:\Projects\Portfolio-dotNet\LeetCode";
            var path = Path.Combine(basePath, @"TestData\RemoveKdigits_input.txt");
            using (var sr = new StreamReader(path))
            {
                num = sr.ReadToEnd();
            }

            k = 1000;

            path = Path.Combine(basePath, @"TestData\RemoveKdigits_output.txt");
            using (var sr = new StreamReader(path))
            {
                output = sr.ReadToEnd();
            }

            Assert.Equal(output, s.RemoveKdigits(num, k));
        }

        [Fact]
        public void TrieTest()
        {
            var trie = new Trie();

            string word1 = "apple", word2 = "app";

            trie.Insert(word1);

            Assert.True(trie.Search(word1));
            Assert.False(trie.Search(word2));
            Assert.True(trie.StartsWith(word2));

            trie.Insert(word2);

            Assert.True(trie.Search(word2));
        }

        [Fact]
        public void MaxSubarraySumCircularTest()
        {
            var s = new Solution();
            int[] A;

            A = new int[] { 1, -2, 3, -2 };
            Assert.Equal(3, s.MaxSubarraySumCircular(A));

            A = new int[] { 5, -3, 5 };
            Assert.Equal(10, s.MaxSubarraySumCircular(A));

            A = new int[] { 3, -1, 2, -1 };
            Assert.Equal(4, s.MaxSubarraySumCircular(A));

            A = new int[] { 3, -2, 2, -3 };
            Assert.Equal(3, s.MaxSubarraySumCircular(A));

            A = new int[] { -2, -3, -1 };
            Assert.Equal(-1, s.MaxSubarraySumCircular(A));
        }

        [Fact]
        public void OddEvenListTest()
        {
            var s = new Solution();
            ListNode input, expected;

            input = ListNode.Build(new int[] { 1, 2, 3, 4, 5 });
            expected = ListNode.Build(new int[] { 1, 3, 5, 2, 4 });
            Assert.Equal(expected, s.OddEvenList(input));

            input = ListNode.Build(new int[] { 2, 1, 3, 5, 6, 4, 7 });
            expected = ListNode.Build(new int[] { 2, 3, 6, 7, 1, 5, 4 });
            Assert.Equal(expected, s.OddEvenList(input));

            // 1 2 3
            // 1[3]2

            // 1 2 3 4
            // 1[3]2 4

            // 1 2 3 4 5
            // 1[3]2 4 5
            // 1 3[5]2 4

            // 1 2 3 4 5 6
            // 1[3]2 4 5 6
            // 1 3[5]2 4 6
        }
    }
}