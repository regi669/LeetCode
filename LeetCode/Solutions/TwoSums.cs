namespace LeetCode.Solutions
{
    public class TwoSums
    {
        /*
         Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
         You may assume that each input would have exactly one solution, and you may not use the same element twice.
         You can return the answer in any order.
        */

        public int[] TwoSum(int[] nums, int target)
        {
            List<int> result = new();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (nums[i] + nums[j] == target)
                    {
                        result.Add(i);
                        result.Add(j);
                        return result.ToArray();
                    }
                }
            }

            return result.ToArray();
        }
    }
}