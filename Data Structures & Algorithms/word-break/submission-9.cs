public class Solution
{
    HashSet<string> words;
    Dictionary<int, bool> memo = new Dictionary<int, bool>();

    public bool WordBreak(string s, List<string> wordDict)
    {
        words = new HashSet<string>(wordDict);
        return DFS(s, 0);
    }

    private bool DFS(string s, int i)
    {
        if (i == s.Length) return true;
        if (memo.ContainsKey(i)) return memo[i];

        var sb = new StringBuilder();
        for (int j = i; j < s.Length; j++)
        {
            sb.Append(s[j]);
            if (words.Contains(sb.ToString()) && DFS(s, j + 1))
            {
                memo[i] = true;
                return true;
            }
        }

        memo[i] = false;
        return false;
    }
}
