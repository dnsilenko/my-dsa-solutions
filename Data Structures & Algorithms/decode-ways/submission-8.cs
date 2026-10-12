public class Solution
{
    int[] memo;
    public int NumDecodings(string s)
    {
        memo = new int[s.Length];
        Array.Fill(memo, -1);

        return DFS(s, 0);
    }

    private int DFS(string s, int i)
    {
        if (i >= s.Length) return 1;
        if (s[i] == '0') return 0;
        if (memo[i] != -1) return memo[i];

        int result = DFS(s, i + 1);
        if (i + 1 < s.Length && (s[i] == '1' ||
            (s[i] == '2' && s[i + 1] < '7')))
        {
            result += DFS(s, i + 2);
        }

        memo[i] = result;
        return result;
    }
}
