public class Solution
{
    public string MinWindow(string s, string t)
    {
        if (s.Length < t.Length) return string.Empty;
        else if (t == string.Empty) return string.Empty;

        var countT = new Dictionary<char, int>();
        var window = new Dictionary<char, int>();    
   
        foreach (char ch in t)
        {
            if (countT.ContainsKey(ch)) countT[ch]++;
            else countT[ch] = 1;
        }

        int l = 0, length = int.MaxValue;
        int have = 0, need = countT.Count;
        int[] res = { -1, -1 };

        for (int r = 0; r < s.Length; r++)
        {
            if (window.ContainsKey(s[r])) window[s[r]]++;
            else window[s[r]] = 1;

            if (countT.ContainsKey(s[r]) && window[s[r]] == countT[s[r]]) have++;

            while (have == need)
            {
                if (r - l + 1 < length)
                {
                    length = r - l + 1;
                    res[0] = l;
                    res[1] = r;
                }
                
                window[s[l]]--;   
                if (countT.ContainsKey(s[l]) && window[s[l]] < countT[s[l]]) have--;

                l++;
            }
        }

        return res[0] == -1 ? string.Empty : s.Substring(res[0], length);
    }
}
