using System;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode retVal = null,
                        tail = null,
                        newNode;
            int l1val,
                l2val,
                sum,
                remainder = 0;

            while (l1 != null || l2 != null)
            {
                l1val = (l1 != null) ? l1.val : 0;
                l2val = (l2 != null) ? l2.val : 0;
                sum = l1val + l2val + remainder;
                remainder = 0;

                if (sum > 9)
                {
                    remainder = sum / 10;
                    sum = sum % 10;
                }

                newNode = new ListNode(sum);
                if (tail != null)
                {
                    tail.next = newNode;
                    tail = newNode;
                }
                else
                {
                    retVal = newNode;
                    tail = newNode;
                }

                l1 = l1?.next;
                l2 = l2?.next;
            }

            while (remainder > 0)
            {
                newNode   = new ListNode(remainder % 10);
                tail.next = newNode;
                tail      = newNode;
                remainder = remainder / 10;
            }

            return retVal;
        }
    }
}