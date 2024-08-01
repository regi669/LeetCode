namespace LeetCode.Solutions
{
    public class LongestCommonPrefixProblem
    {
        /*
         Write a function to find the longest common prefix string amongst an array of strings.
         If there is no common prefix, return an empty string "".
        */

        public string LongestCommonPrefix(string[] strs)
        {
            string? minBy = strs.ToList().MinBy(s => s.Length);

            if (string.IsNullOrEmpty(minBy))
            {
                return string.Empty;
            }

            string prefix = minBy;

            foreach (string s in strs)
            {
                for (int i = 0; i < prefix.Length; i++)
                {
                    if (s[i] != prefix[i])
                    {
                        prefix = prefix.Remove(i);
                    }
                }
            }

            return prefix;
        }
    }
}