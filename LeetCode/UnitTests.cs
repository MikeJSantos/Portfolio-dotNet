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
            
            arr = new int[] {1,2,3}; // 2
            Assert.Equal(2 , s.CountElements(arr));

            arr = new int[] {1,1,3,3,5,5,7,7}; // 0
            Assert.Equal(0, s.CountElements(arr));

            arr = new int[] {1,3,2,3,5,0}; // 3
            Assert.Equal(3 , s.CountElements(arr));

            arr = new int[] {1,1,1,1,2,2}; // 4
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

            intArray = new int[] { 1,2 }; // 1
            Assert.Equal(1, s.MaxProfit(intArray));

            intArray = new int[] { 2,1,4,5,2,9,7 }; // 11
            Assert.Equal(11, s.MaxProfit(intArray));
            // TODO: Fix this!
        }

        [Fact]
        public void MiddleNodeTest()
        {
            var s = new Solution();
            ListNode node;

            node = ListNode.Build(new int[] {1,2,3,4,5});
            Assert.Equal(3, s.MiddleNode(node).val);

            node = ListNode.Build(new int[] {1,2,3,4,5,6});
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

            stones = new int[] {2,7,4,1,8,1};
            Assert.Equal(1, s.LastStoneWeight(stones));

            stones = new int[] {7,6,7,6,9};
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
            shift = new int[][] { new int[] {0,1}, new int[] {1,2} };
            Assert.Equal("cab", s.StringShift(inputStr, shift));

            inputStr = "abcdefg";
            shift = new int[][] { new int[] {1,1}, new int[] {1,1}, new int[] {0,2}, new int[] {1,3} };
            Assert.Equal("efgabcd", s.StringShift(inputStr, shift));
        }

        [Fact]
        public void DiameterOfBinaryTreeTest()
        {
            var s = new Solution();

            var leftNode = new Solution.TreeNode(2,4,5);
            var head = new Solution.TreeNode(1, leftNode, new Solution.TreeNode(3));

            Assert.Equal(3, s.DiameterOfBinaryTree(head));

            head = new Solution.TreeNode(1);
            Assert.Equal(0, s.DiameterOfBinaryTree(head));

            head = new Solution.TreeNode(1, new Solution.TreeNode(2), null);
            Assert.Equal(1, s.DiameterOfBinaryTree(head));
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
    }
}