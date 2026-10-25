public class Solution
{
    public int UniquePaths(int m, int n)
    {
        var grid = new int[m, n];          
        
        for (int i = 0; i < n; i++)
            grid[0, i] = 1;

        for (int i = 0; i < m; i++)
            grid[i, 0] = 1;  

        for (int i = 1; i < n; i++)
            for (int j = 1; j < m; j++)
                grid[j, i] = grid[j - 1, i] + grid[j, i - 1];

        return grid[m - 1, n - 1];
    }
}
