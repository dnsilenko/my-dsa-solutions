public class Solution
{
    public bool WordBreak(string s, List<string> wordDict)
    {
        var hs = new HashSet<string>(wordDict);
        var memoization = new bool?[s.Length];
        return DFS(0, s, hs, memoization);
    }

    private bool DFS(int i, string s, HashSet<string> hs, bool?[] memoization)
    {
        if (i >= s.Length) return true;
        if (memoization[i].HasValue) return memoization[i].Value;
        
        for (int j = i; j < s.Length; j++)
        {
            if (hs.Contains(s.Substring(i, j - i + 1)) &&
                DFS(j + 1, s, hs, memoization))
            {
                memoization[i] = true; return true;
            }
        }

        memoization[i] = false; return false;
    }
}