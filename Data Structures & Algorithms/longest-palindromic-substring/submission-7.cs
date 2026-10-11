public class Solution
{
    public string LongestPalindrome(string s)
    {
        int index = 0;
        int length = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int l = i, r = i + 1; // even-length
            while (l >= 0 && r < s.Length && s[l] == s[r]) 
            {
                l--;    
                r++;
            }

            l++; r--;
            if (length < r - l + 1) 
            {
                length = r - l + 1;
                index = l;
            }

            l = i - 1;
            r = i + 1;
            while (l >= 0 && r < s.Length && s[l] == s[r]) // odd-length
            {
                l--;    
                r++;
            }

            l++; r--;
            if (length < r - l + 1) 
            {
                length = r - l + 1;
                index = l;
            }
        }

        return s.Substring(index, length);
    }
}
