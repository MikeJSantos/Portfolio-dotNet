namespace LeetCode
{
    public partial class Solution
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            
            ListNode currentNode  = head,
                     previousNode = null,
                     lastOddNode  = null;                        ;
            bool isCurrentNodeOdd = true;

            while (currentNode != null)
            {
                if (lastOddNode == null)
                    lastOddNode = currentNode;
                    
                if (isCurrentNodeOdd && lastOddNode.val != currentNode.val)
                {
                    var newNode = new ListNode(currentNode.val, lastOddNode.next);

                    lastOddNode.next  = newNode;
                    lastOddNode       = newNode;
                    previousNode.next = currentNode.next;
                }

                isCurrentNodeOdd = !isCurrentNodeOdd;
                previousNode     = currentNode;
                currentNode      = currentNode.next;
            }

            return head;
        }
    }
}