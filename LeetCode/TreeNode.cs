namespace LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }

        public TreeNode(int x = 0, TreeNode leftNode = null, TreeNode rightNode = null)
        {
            val = x;
            left = leftNode;
            right = rightNode;
        }

        public TreeNode(int x = 0, int leftValue = 0, int rightValue = 0)
        {
            val = x;
            left = new TreeNode(leftValue);
            right = new TreeNode(rightValue);
        }
    }
}