public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int length = 0;
        char max = s[0];
        Dictionary<char, int> window = new();

        for (int l = 0, r = 0; r < s.Length; r++)
        {
            if (!window.ContainsKey(s[r])) window[s[r]] = 0;
            window[s[r]]++;

            if (window[max] < window[s[r]]) max = s[r];

            if (r - l + 1 - window[max] > k) 
            {
                window[s[l]]--;
                l++;
            }

            length = Math.Max(length, r - l + 1);
        }

        return length;
    }
}
