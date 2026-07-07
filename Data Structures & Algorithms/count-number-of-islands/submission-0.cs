public class Solution {
    public int NumIslands(char[][] grid)
    {
        var visited = new bool[grid.Length, grid[0].Length];
        int counter = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (DFS(i, j, grid, visited)) counter++;
            }
        }

        return counter;
    }

    private bool DFS(int r, int c, char[][] grid, bool[,] visited)
    {
        if (r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length ||
            grid[r][c] == '0' || visited[r, c]) return false;

        visited[r, c] = true;
        DFS(r + 1, c, grid, visited);
        DFS(r - 1, c, grid, visited);
        DFS(r, c + 1, grid, visited);
        DFS(r, c - 1, grid, visited);

        return true;
    }
}
