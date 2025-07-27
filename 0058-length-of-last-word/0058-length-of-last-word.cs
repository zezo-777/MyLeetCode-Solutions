public class Solution {
        public int LengthOfLastWord(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            int wordLength = 0;
            bool foundChar = false;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    if (foundChar)
                        break;
                }
                else
                {
                    foundChar = true;
                    wordLength++;
                }
            }
            return wordLength;

        }
}