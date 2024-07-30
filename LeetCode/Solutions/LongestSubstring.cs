namespace LeetCode.Solutions
{
    public class LongestSubstring
    {
        /*
         Given a string s, find the length of the longest substring without repeating characters.
        */

        public int LengthOfLongestSubstring(string s, int maxLength = 0)
        {
            List<char> result = new();
            int length = 0;

            foreach (char c in s)
            {
                while (result.Contains(c))
                {
                    result.RemoveAt(0);
                    length = result.Count;
                }

                result.Add(c);
                length++;

                if (length > maxLength)
                {
                    maxLength = length;
                }
            }

            return maxLength;
        }
    }
}