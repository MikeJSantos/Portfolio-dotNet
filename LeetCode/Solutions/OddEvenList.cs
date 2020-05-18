using System;

namespace LeetCode
{
    public partial class Solution
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            
            var currentNode = head;
            ListNode lastOddNode = null,
                     lastEvenNode = null,
                     tempNode = null;
            bool isCurrentNodeEven = false;

            while (currentNode != null)
            {
                tempNode = new ListNode(currentNode.val);

                if (lastOddNode == null)
                    lastOddNode = currentNode;
                else if (lastEvenNode == null)
                    lastEvenNode = currentNode;
                else if (!isCurrentNodeEven && lastOddNode.val != currentNode.val)
                {
                    lastEvenNode.next = currentNode.next ?? lastEvenNode.next;
                    tempNode.next = lastEvenNode;
                    lastOddNode.next = tempNode;

                    lastEvenNode = lastEvenNode.next;
                    lastOddNode = lastOddNode.next;
                }
                else if (isCurrentNodeEven && lastEvenNode.val != currentNode.val)
                {
                    lastOddNode.next = currentNode.next ?? lastOddNode.next;
                    tempNode.next = lastEvenNode;
                    lastEvenNode.next = tempNode;

                    lastEvenNode = lastEvenNode.next;
                    lastOddNode = lastOddNode.next;
                }

                isCurrentNodeEven = !isCurrentNodeEven;
                currentNode = currentNode.next;
            }

            return head;
        }
    }
}