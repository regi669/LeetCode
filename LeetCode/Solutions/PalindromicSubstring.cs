namespace LeetCode.Solutions
{
    public class PalindromicSubstring
    {
        /*
         Given a string s, return the longest palindromic substring in s.
        */

        public string LongestPalindrome(string s)
        {
            string copyS = s;

            string maxPalindrome = "";

            bool breakLoop = IsPalindrome(copyS);

            while (!breakLoop)
            {
                copyS = copyS.Substring(1);
                breakLoop = IsPalindrome(copyS);

                char[] arr = copyS.ToCharArray();
                Array.Reverse(arr);
                string arrRev = new(arr);

                bool breakLoop2 = IsPalindrome(arrRev);

                while (!breakLoop2)
                {
                    arrRev = arrRev.Substring(1);
                    breakLoop2 = IsPalindrome(arrRev);
                }

                if (arrRev.Length > maxPalindrome.Length)
                {
                    maxPalindrome = arrRev;
                }
            }

            copyS = s;

            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string copySReversed = new(charArray);

            while (!IsPalindrome(copySReversed))
            {
                copySReversed = copySReversed.Substring(1);
            }

            if (copySReversed.Length > maxPalindrome.Length)
            {
                maxPalindrome = copySReversed;
            }

            return maxPalindrome;
        }

        public bool IsPalindrome(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string newString = new(charArray);

            if (s == newString)
            {
                return true;
            }

            return false;
        }
    }
}