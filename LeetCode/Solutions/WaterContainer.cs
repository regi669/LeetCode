namespace LeetCode.Solutions
{
    public class WaterContainer
    {
        /*
         You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
         Find two lines that together with the x-axis form a container, such that the container contains the most water.
         Return the maximum amount of water a container can store.
         Notice that you may not slant the container.
        */

        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                int area = 0;
                int ht = 0;
                int diff = right - left;

                if (height[left] < height[right])
                {
                    ht = height[left];
                    left++;
                }

                else if (height[right] < height[left])
                {
                    ht = height[right];
                    right--;
                }
                else if (height[right] == height[left])
                {
                    ht = height[left];
                    left++;
                }

                area = ht * diff;

                if (area > maxArea)
                {
                    maxArea = area;
                }
            }

            return maxArea;
        }
    }
}