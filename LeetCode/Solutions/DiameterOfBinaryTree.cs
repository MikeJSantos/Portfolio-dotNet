using System;

namespace LeetCode
{
    public partial class Solution
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }

            public TreeNode(int x, TreeNode leftNode, TreeNode rightNode)
            {
                val   = x;
                left  = leftNode;
                right = rightNode;
            }

            public TreeNode(int x, int leftValue, int rightValue)
            {
                val   = x;
                left  = new TreeNode(leftValue);
                right = new TreeNode(rightValue);
            }
        }

        public int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null) return 0;
            return DiameterOfBinaryTreeRecurse(root, 0);
        }

        private int DiameterOfBinaryTreeRecurse(TreeNode node, int depth)
        {
            if (node == null) return depth - 1;

            var leftDepth  = DiameterOfBinaryTreeRecurse(node.left, depth + 1);
            var rightDepth = DiameterOfBinaryTreeRecurse(node.right, depth + 1);

            if (depth == 0)
                return leftDepth + rightDepth;
            else
                return leftDepth >= rightDepth ? leftDepth : rightDepth;
        }
    }
}