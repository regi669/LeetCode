using LeetCode.BaseClassess;

namespace LeetCode.Solutions
{
    public class AddTwoLists
    {
        /*
         You are given two non-empty linked lists representing two non-negative integers.
         The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
         You may assume the two numbers do not contain any leading zero, except the number 0 itself.
        */

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (Len(l2) > Len(l1))
            {
                (l2, l1) = (l1, l2);
            }

            ListNode result = new(-1);

            ListNode prev = l1;

            int overflow = 0;

            do
            {
                int resultInt = overflow + l1.val;

                if (overflow == 1)
                {
                    overflow = 0;
                }

                if (l2 != null)
                {
                    resultInt += l2.val;

                    l2 = l2.next;
                }

                if (resultInt >= 10)
                {
                    resultInt -= 10;
                    overflow = 1;
                }

                if (result.val != -1)
                {
                    result = new(resultInt, result);
                }
                else
                {
                    result = new(resultInt);
                }

                prev = l1;
                l1 = l1.next;
            } while (prev.next != null);

            if (overflow == 1)
            {
                ListNode oneNode = new(1, result);
                result = oneNode;
            }

            ListNode reversedResult = reverse_list(result);

            return reversedResult;
        }

        public ListNode reverse_list(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode prev = null;
            ListNode current = head;

            while (current != null)
            {
                ListNode next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            return prev;
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