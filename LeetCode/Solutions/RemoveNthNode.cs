using LeetCode.BaseClassess;

namespace LeetCode.Solutions
{
    public class RemoveNthNode
    {
        /*
         Given the head of a linked list, remove the nth node from the end of the list and return its head.
        */

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null)
            {
                return head;
            }

            int len = Len(head);

            n = len - n;

            if (n == 0)
            {
                head = head.next;
                return head;
            }

            ListNode prev = null;
            ListNode current = head;
            int counter = 0;

            for (int i = 0; current != null && i < n; i++)
            {
                prev = current;
                current = current.next;
            }

            if (current.next != null)
            {
                prev.next = current.next;
            }
            else
            {
                prev.next = null;
            }

            return head;
        }

        public int Len(ListNode head)
        {
            int result = 0;
            ListNode current = head;

            while (current != null)
            {
                current = current.next;
                result++;
            }

            return result;
        }
    }
}