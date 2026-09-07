public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int l = 0, result = 0, maxFreq = 0;
        var count = new Dictionary<char, int>();
        
        for (int r = 0; r < s.Length; r++)
        {
            if (count.ContainsKey(s[r])) count[s[r]]++;
            else count[s[r]] = 1;

            maxFreq = Math.Max(maxFreq, count[s[r]]);
            while (r - l + 1 - maxFreq > k)
            {
                count[s[l]]--;
                l++;
            }

            result = Math.Max(result, r - l + 1);
        }

        return result;
    }
}