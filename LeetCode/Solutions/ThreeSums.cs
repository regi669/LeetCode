namespace LeetCode.Solutions
{
    public class ThreeSums
    {
        /*
         Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
         Notice that the solution set must not contain duplicate triplets.
        */

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> result = new();
            Array.Sort(nums);
            int pre = 0;

            for (int i = nums.Length - 1; i > 1; i--)
            {
                if (i != nums.Length - 1 && nums[i] == pre)
                {
                    continue;
                }

                int remain = 0 - nums[i];
                pre = nums[i];
                int prev = 0;

                for (int j = i - 1; j > 0; j--)
                {
                    if (j != i - 1 && nums[j] == prev)
                    {
                        continue;
                    }

                    int last = remain - nums[j];
                    prev = nums[j];
                    int exist = Array.BinarySearch<int>(nums, 0, j, last);

                    if (exist >= 0)
                    {
                        result.Add(new List<int>() { nums[i], nums[j], last });
                    }
                }
            }

            return result;
        }
    }
}