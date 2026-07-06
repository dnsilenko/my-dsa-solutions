public class Solution {
    public int IslandPerimeter(int[][] grid)
    {
        var visited = new bool[grid.Length, grid[0].Length];
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 1) return DFS(i, j, grid, visited);
            }
        }

        return 0;
    }

    private int DFS(int r, int c, int[][] grid, bool[,] visited)
    {
        if (r >= grid.Length || c >= grid[0].Length ||
            r < 0 || c < 0 || grid[r][c] == 0) return 1;

        if (visited[r, c]) return 0;

        visited[r, c] = true;
        int left = DFS(r, c - 1, grid, visited);
        int right = DFS(r, c + 1, grid, visited);
        int up = DFS(r - 1, c, grid, visited);
        int down = DFS(r + 1, c, grid, visited);

        return left + right + up + down;
    }
}