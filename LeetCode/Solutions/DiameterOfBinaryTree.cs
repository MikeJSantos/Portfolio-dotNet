namespace LeetCode
{
    public partial class Solution
    {
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