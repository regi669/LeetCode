namespace LeetCode.Solutions
{
    public class SearchInsertPosition
    {
        /*
         Given a sorted array of distinct integers and a target value,
         return the index if the target is found. If not, return the index where it would be if it were inserted in order.
         You must write an algorithm with O(log n) runtime complexity.
        */

        public int SearchInsert(int[] nums, int target)
        {
            return SearchInsertRecurring(nums, target);
        }

        public int SearchInsertRecurring(int[] nums, int target, bool isReccurring = false)
        {
            if (nums.Length > 0 && target < nums[0])
            {
                return 0;
            }

            int index = Array.BinarySearch(nums, target);

            if (isReccurring)
            {
                index++;
            }

            if (index > 0)
            {
                return index;
            }

            return SearchInsertRecurring(nums, target - 1, true);
        }
    }
}