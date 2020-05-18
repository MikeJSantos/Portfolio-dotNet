using System;
using Xunit;

namespace LeetCode
{
    public partial class Solution
    {
        public bool IsCousins(TreeNode root, int x, int y)
        {
            if (root == null || root.left == null || root.right == null)
                return false;

            var nodeX = IsCousins_FindNode(root, x, 0);
            var nodeY = IsCousins_FindNode(root, y, 0);

            return (nodeX != null && nodeY != null) &&
                    nodeX.Item1 != nodeY.Item1 && // different parents
                    nodeX.Item2 == nodeY.Item2;   // same depth
        }

        // Return value is the found node's parent & the found node's depth
        private Tuple<TreeNode, int> IsCousins_FindNode(TreeNode node, int value, int depth)
        {   
            // Edge case for when the root node is the match
            if (node == null || node.val == value)
                return null;

            if ((node.left != null && node.left.val == value) ||
                (node.right != null && node.right.val == value))
                return new Tuple<TreeNode, int>(node, depth);

            var leftNode = IsCousins_FindNode(node.left, value, depth + 1);
            var rightNode = IsCousins_FindNode(node.right, value, depth + 1);

            return leftNode ?? rightNode;
        }
    }

    public partial class UnitTests
    {
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
    }
}