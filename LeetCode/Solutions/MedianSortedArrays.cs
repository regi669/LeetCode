namespace LeetCode.Solutions
{
    public class MedianSortedArrays
    {
        /*
         Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
         The overall run time complexity should be O(log (m+n)).
        */

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] arr = nums1.Concat(nums2).ToArray();
            Array.Sort(arr);
            return median(arr);
        }

        public double median(int[] nums)
        {
            if (nums.Length % 2 == 0)
            {
                return (double)(nums[nums.Length / 2 - 1] + nums[nums.Length / 2]) / 2;
            }

            return nums[(nums.Length - 1) / 2];
        }
    }
}