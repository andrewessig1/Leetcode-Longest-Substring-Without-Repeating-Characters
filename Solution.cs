public class Solution {
    public int LengthOfLongestSubstring(string s) {
            string cur = "";
            string longest = "";
            int i = 0;
            int start = 0;
            while (i < s.Length)
            {
                if (!cur.Contains(s.Substring(i, 1)))
                {
                    cur += s.Substring(i, 1);
                    i++;
                }
                else
                {
                    cur = "";
                    start++;
                    i = start;
                }
                if(cur.Length > longest.Length)
                {
                    longest = cur;
                }
            }
            return longest.Length < cur.Length ? cur.Length : longest.Length;
    }
}
