public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        var dict1 = new Dictionary<char, int>();
        var dict2 = new Dictionary<char, int>();

        foreach (char ch in s)
        {
            if (dict1.ContainsKey(ch)) dict1[ch]++;
            else dict1[ch] = 1;
        }

        foreach (char ch in t)
        {
            if (dict2.ContainsKey(ch)) dict2[ch]++;
            else dict2[ch] = 1;
        }

        foreach (var ch in dict1.Keys)
        {
            if (!dict2.ContainsKey(ch)) return false;
            if (dict1[ch] != dict2[ch]) return false;
        }

        foreach (var ch in dict2.Keys)
        {
            if (!dict1.ContainsKey(ch)) return false;
            if (dict2[ch] != dict1[ch]) return false;
        }

        return true;    
    }
}
