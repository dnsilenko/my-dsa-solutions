public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s == string.Empty) return 0;
        if (string.IsNullOrWhiteSpace(s)) return 1;

        int max = 0;
        int l = 0, r = 0;
        var hs = new HashSet<char>();

        while (r < s.Length)
        {
            if (!hs.Contains(s[r])) hs.Add(s[r++]);
            else
            {
                max = Math.Max(max, hs.Count);
                while (hs.Contains(s[r])) hs.Remove(s[l++]);
            }
        }  

        return Math.Max(max, hs.Count);
    }
}