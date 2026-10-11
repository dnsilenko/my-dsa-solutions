public class Solution
{
    public string LongestPalindrome(string s)
    {
        int length = 0;
        string result = string.Empty;

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
                result = s.Substring(l, length);   
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
                result = s.Substring(l, length);   
            }
        }

        return result;
    }
}
