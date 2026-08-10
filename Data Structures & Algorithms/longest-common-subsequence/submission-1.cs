public class Solution
{
    public int LongestCommonSubsequence(string text1, string text2)
    {
        var memo = new int[text1.Length, text2.Length];
        for (int i = 0; i < memo.GetLength(0); i++)
            for (int j = 0; j < memo.GetLength(1); j++)
                memo[i, j] = -1;

        return DFS(text1, text2, 0, 0, memo);      
    }

    private int DFS(string text1, string text2, int i, int j, int[,] memo)
    {
        if (i == text1.Length || j == text2.Length) return 0;
        if (memo[i, j] != -1) return memo[i, j];

        if (text1[i] == text2[j])
        {
            memo[i, j] = 1 + DFS(text1, text2, i + 1, j + 1, memo);
        }
        else
        {
            memo[i, j] = Math.Max(
                DFS(text1, text2, i + 1, j, memo),
                DFS(text1, text2, i, j + 1, memo));
        }

        return memo[i, j];
    }
}
