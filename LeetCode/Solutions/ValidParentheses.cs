namespace LeetCode.Solutions
{
    public class ValidParentheses
    {
        /*
         Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
         An input string is valid if:

         Open brackets must be closed by the same type of brackets.
         Open brackets must be closed in the correct order.
         Every close bracket has a corresponding open bracket of the same type.
        */

        public bool IsValid(string s)
        {
            List<char> brackeList = new();

            List<char> badBracketList = new();

            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    brackeList.Add(c);
                }

                char last = brackeList.LastOrDefault();
                int lastIndex = brackeList.LastIndexOf(last);

                if (last == null)
                {
                    continue;
                }

                CheckChar(last, c, brackeList, lastIndex, badBracketList, '(', ')');
                CheckChar(last, c, brackeList, lastIndex, badBracketList, '[', ']');
                CheckChar(last, c, brackeList, lastIndex, badBracketList, '{', '}');

                if (badBracketList.Count > 0)
                {
                    return false;
                }
            }

            return brackeList.Count == 0 && badBracketList.Count == 0;
        }

        private static void CheckChar(char last, char c, List<char> brackeList, int lastIndex, List<char> badBracketList, char braceOpen, char braceClosed)
        {
            if (last == braceOpen && c == braceClosed)
            {
                brackeList.RemoveAt(lastIndex);
            }
            else if (c == braceClosed)
            {
                badBracketList.Add(c);
            }
        }
    }
}