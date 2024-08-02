namespace LeetCode.Solutions
{
    public class GenerateParentheses
    {
        /*
         Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
        */

        public IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new();

            GenerateCombinations(0, 0, n, string.Empty, result);

            return result;
        }

        public void GenerateCombinations(int open, int closed, int n, string s, List<string> result)
        {
            if (open == closed && open + closed == n * 2)
            {
                result.Add(s);
            }

            if (open < n)
            {
                GenerateCombinations(open + 1, closed, n, s + '(', result);
            }

            if (closed < open)
            {
                GenerateCombinations(open, closed + 1, n, s + ')', result);
            }
        }
    }
}