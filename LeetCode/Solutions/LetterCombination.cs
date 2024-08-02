namespace LeetCode.Solutions
{
    public class LetterCombination
    {
        /*
         Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.
         A mapping of digits to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.
        */

        public IList<string> LetterCombinations(string digits)
        {
            if (digits == string.Empty)
            {
                return [];
            }

            IDictionary<char, string> combination = new Dictionary<char, string>()
            {
                { '1', string.Empty },
                { '2', "abc" },
                { '3', "def" },
                { '4', "ghi" },
                { '5', "jkl" },
                { '6', "mno" },
                { '7', "pqrs" },
                { '8', "tuv" },
                { '9', "wxyz" }
            };

            IList<string> result = new List<string>();

            List<List<char>> lists = new();

            foreach (char digit in digits)
            {
                if (combination.ContainsKey(digit))
                {
                    List<char> ls = new();

                    foreach (char c in combination[digit])
                    {
                        ls.Add(c);
                    }

                    lists.Add(ls);
                }
            }

            GenerateCombinations(lists, result, 0, "");

            return result;
        }

        private static void GenerateCombinations(List<List<char>> lists, IList<string> result, int depth, string current)
        {
            if (depth == lists.Count)
            {
                result.Add(current);
                return;
            }

            foreach (char c in lists[depth])
            {
                GenerateCombinations(lists, result, depth + 1, current + c);
            }
        }
    }
}