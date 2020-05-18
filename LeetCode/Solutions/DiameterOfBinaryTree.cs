using System.Linq;
using System.Collections.Generic;

namespace LeetCode
{
    public partial class Solution
    {
        // TODO: Optimize 
        //  Runtime: 112 ms, faster than 17.37%.
        //  Memory Usage: 26.3 MB, less than 25.00%
        public int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null) return 0;

            var maxDiameter = 0;
            var nodeQueue = new Queue<TreeNode>();
            nodeQueue.Enqueue(root);

            while (nodeQueue.Any())
            {
                var node = nodeQueue.Dequeue();

                if (node.left != null)
                    nodeQueue.Enqueue(node.left);
                if (node.right != null)
                    nodeQueue.Enqueue(node.right);
                
                var diameter = DiameterOfBinaryTreeRecurse(node, 0);
                if (diameter > maxDiameter)
                    maxDiameter = diameter;
            }

            return maxDiameter;
        }

        private int DiameterOfBinaryTreeRecurse(TreeNode node, int depth)
        {
            if (node == null)
                return depth - 1; // Redundant?

            var leftDepth  = node.left != null
                ? DiameterOfBinaryTreeRecurse(node.left, depth + 1)
                : depth;
            var rightDepth = node.right != null
                ? DiameterOfBinaryTreeRecurse(node.right, depth + 1)
                : depth;

            if (depth == 0)
                return leftDepth + rightDepth;
            else
                return leftDepth >= rightDepth ? leftDepth : rightDepth;
        }
    }
}