public class Solution
{
    public int NumIslands(char[][] grid)
    {
        var visited = new bool[grid.Length][];
        for (int i = 0; i < grid.Length; i++)
            visited[i] = new bool[grid[0].Length];
    
        int counter = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (DFS(grid, i, j, visited)) counter++;
            }
        }

        return counter;
    }

    private bool DFS(char[][] grid, int i, int j, bool[][] visited)
    {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length) return false;
        if (visited[i][j] || grid[i][j] == '0') return false;

        visited[i][j] = true;
        DFS(grid, i + 1, j, visited);
        DFS(grid, i - 1, j, visited);
        DFS(grid, i, j + 1, visited);
        DFS(grid, i, j - 1, visited);

        return true;
    }
}
