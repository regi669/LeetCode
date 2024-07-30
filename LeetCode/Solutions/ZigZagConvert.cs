namespace LeetCode.Solutions
{
    public class ZigZagConvert
    {
        /*
         The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

           P   A   H   N
           A P L S I I G
           Y   I   R

        Input: s = "PAYPALISHIRING", numRows = 4
                   Output: "PINALSIGYAHRPI"
                   Explanation:
                   P     I    N
                   A   L S  I G
                   Y A   H R
                   P     I
        */

        public string Convert(string s, int numRows)
        {
            //1234321
            //123454321

            IDictionary<int, string> dict = new Dictionary<int, string>();

            int counter = 0;
            int difference = 1;

            for (int i = 0; i < s.Length; i++)
            {
                int key = counter;

                if (counter == numRows - 1)
                {
                    difference = -1;
                }

                if (counter == 0)
                {
                    difference = 1;
                }

                counter += difference;

                if (dict.ContainsKey(key))
                {
                    dict[key] = $"{dict[key]}{s[i]}";
                }
                else
                {
                    dict.Add(key, $"{s[i]}");
                }
            }

            string result = "";

            foreach (KeyValuePair<int, string> pair in dict)
            {
                result = $"{result}{pair.Value}";
            }

            return result;
        }
    }
}