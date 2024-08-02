using LeetCode.BaseClassess;

namespace LeetCode.Solutions
{
    public class MergeNSortedLists
    {
        /*
         You are given the heads of two sorted linked lists list1 and list2.
         Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.
         Return the head of the merged linked list.
        */

        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0)
            {
                return null;
            }

            ListNode result = null;

            foreach (ListNode list in lists)
            {
                result = MergeTwoLists(result, list);
            }

            return result;
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode result = new();
            ListNode current = result;

            while (list1 != null && list2 != null)
            {
                if (list1.val > list2.val)
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                else
                {
                    current.next = list1;
                    list1 = list1.next;
                }

                current = current.next;
            }

            current.next = list1 != null ? list1 : list2;

            return result.next;
        }
    }
}