public class Solution
{
    int[,] memo;
    public int UniquePaths(int m, int n)
    {         
        memo = new int[m, n];

        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                memo[i, j] = -1;

        return DFS(m, n, 0, 0);
    }

    private int DFS(int m, int n, int i, int j)
    {
        if (i == m - 1 || j == n - 1) return 1;
        if (memo[i, j] != -1) return memo[i, j];
        
        memo[i, j] = DFS(m, n, i, j + 1) + DFS(m, n, i + 1, j);
        return memo[i, j];
    }
}
