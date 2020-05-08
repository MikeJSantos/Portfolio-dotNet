using System;

namespace LeetCode
{
    public partial class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            var tuple = MiddleNodeRecurse(head, 1);
            return tuple.Item1;
        }

        // Tuple: ListNode, int (nodeCount)
        public Tuple<ListNode, int> MiddleNodeRecurse(ListNode node, int nodeCount)
        {
            //Console.Out.WriteLine($"{node.val} => [{ListNode.Output(node)}], {nodeCount}");

            // Reached the end of the list & found max distance from head
            if (node.next == null)
                return new Tuple<ListNode, int> (node, nodeCount);

            var tuple = MiddleNodeRecurse(node.next, nodeCount + 1);

            if ((tuple.Item2 % 2 == 0 && (nodeCount - 1) * 2 == tuple.Item2) ||
                (tuple.Item2 % 2 == 1 && nodeCount * 2 == tuple.Item2 + 1))
            {   // Middle node found
                return new Tuple<ListNode, int>(node, tuple.Item2);
            }

            // Console.Out.WriteLine($"<[{iter.Item1.val}], {iter.Item2}>, {nodeCount}");
            return tuple;
        }
    }
}