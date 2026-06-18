public class Solution {
    public int CharacterReplacement(string s, int k) {
        var dict = new Dictionary<char, int>();
        int l = 0, r = 0, max = 0;
        
        while (l < s.Length)
        {
            if (r < s.Length)
            {
                if (dict.ContainsKey(s[r])) dict[s[r]]++;
                else dict[s[r]] = 1;
            }

            int count = r - l + 1 - GetTheMostPopular(dict);
            if (count <= k && r < s.Length)
            { 
                if (r - l + 1 > max) max = r - l + 1;
            }
            else dict[s[l++]]--;

            if (r < s.Length) r++;
        }      

        return max;
    }

    private int GetTheMostPopular(Dictionary<char, int> dict)
    {
        int max = 0;
        foreach (var item in dict)
        {
            if (item.Value > max) max = item.Value;     
        }

        return max;
    }
}