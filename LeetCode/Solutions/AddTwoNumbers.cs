using System;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var num1 = AddTwoNumbers_GetReversedNumFromLL(l1);
            var num2 = AddTwoNumbers_GetReversedNumFromLL(l2);
            var addedNum = num1 + num2;

            ListNode retVal = null, currentNode = null, newNode;

            while (addedNum >= 1.0)
            {
                var modulus = Convert.ToInt32(Math.Floor(addedNum % 10));
                newNode = new ListNode(modulus);

                if (retVal == null)
                {
                    retVal      = newNode;
                    currentNode = newNode;
                }
                else
                {
                    currentNode.next = newNode;
                    currentNode      = newNode;
                }

                addedNum = addedNum / 10;
            }

            return retVal ?? new ListNode(0);
        }

        private double AddTwoNumbers_GetReversedNumFromLL(ListNode root)
        {
            var strBuilder = new StringBuilder();
            var node = root;

            while (node != null)
            {
                strBuilder.Insert(0, node.val);
                node = node.next;
            }

            return double.Parse(strBuilder.ToString());
        }
    }
}