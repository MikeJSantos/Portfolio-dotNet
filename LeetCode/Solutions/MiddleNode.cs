using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace LeetCode
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public static ListNode Build(int[] intArray)
        {
            ListNode head = null;;
            ListNode iterationNode = null;

            foreach(var num in intArray)
            {
                var newNode = new ListNode(num);

                if (head == null)
                {
                    head = newNode;
                    iterationNode = newNode;
                }
                else
                {
                    iterationNode.next = newNode;
                    iterationNode = newNode;
                }
            }

            return head;
        }

        public static string Output(ListNode node)
        {
            var strBuilder = new StringBuilder();

            while (node != null)
            {
                strBuilder.Append(node.val);

                if (node.next != null)
                    strBuilder.Append(" > ");

                node = node.next;
            }

            return strBuilder.ToString();
        }
    }

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