public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var set = new HashSet<char>();
        int l = 0, r = 0, counter = 0, max = 0;
        
        while (l < s.Length)
        {
            if (r < s.Length && !set.Contains(s[r]))
            {
                set.Add(s[r]);
                r++;
                counter++;
            }
            else
            {
                set.Remove(s[l]);
                l++;
                counter--;
            }

            if (counter > max) max = counter;
        }

        return max;
    }
}