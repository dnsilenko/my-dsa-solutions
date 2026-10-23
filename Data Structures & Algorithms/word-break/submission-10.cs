public class Solution
{
    HashSet<string> hs;
    Dictionary<int, bool> dict;

    public bool WordBreak(string s, List<string> wordDict)
    {
        hs = new HashSet<string>(wordDict);  
        dict = new Dictionary<int, bool>();

        return DFS(s, 0);
    }

    private bool DFS(string s, int i)
    {
        if (i == s.Length) return true;
        if (dict.ContainsKey(i)) return dict[i];

        var sb = new StringBuilder();
        for (int j = i; j < s.Length; j++)
        {
            sb.Append(s[j]);
            if (hs.Contains(sb.ToString()) && DFS(s, j + 1))
            {
                dict[i] = true;
                return true;
            }
        }

        dict[i] = false;
        return false;
    }
}
