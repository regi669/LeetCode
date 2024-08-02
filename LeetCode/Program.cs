using LeetCode.BaseClassess;
using LeetCode.Solutions;

MergeNSortedLists mn = new();

IList<ListNode> lists = new List<ListNode>()
{
    new(2),
    null,
    new(-1)
};

ListNode res = mn.MergeKLists(lists.ToArray());
Console.WriteLine();