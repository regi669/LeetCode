using LeetCode.BaseClassess;

namespace LeetCode.Solutions
{
    public class SwapNodesInPairs
    {
        /*
         Given a linked list, swap every two adjacent nodes and return its head.
         You must solve the problem without modifying the values in the list's nodes (i.e., only nodes themselves may be changed.)
        */

        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode dummy = new();
            ListNode prev = dummy;
            ListNode current = head;

            while (current != null && current.next != null)
            {
                prev.next = current.next;
                current.next = current.next.next;
                prev.next.next = current;

                prev = current;
                current = current.next;
            }

            return dummy.next;
        }
    }
}