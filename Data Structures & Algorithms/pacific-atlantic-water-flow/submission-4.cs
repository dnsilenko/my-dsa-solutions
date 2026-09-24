public class Solution
{
    public List<List<int>> PacificAtlantic(int[][] heights)
    {
        var visited = new bool[heights.Length, heights[0].Length];
        var pacific = new HashSet<(int, int)>();
        var atlantic = new HashSet<(int, int)>();

        for (int i = 0; i < heights.Length; i++)
            DFS(heights, i, 0, 0, pacific, visited);

        for (int j = 0; j < heights[0].Length; j++)
            DFS(heights, 0, j, 0, pacific, visited);

        visited = new bool[heights.Length, heights[0].Length];

        for (int i = 0; i < heights.Length; i++)
            DFS(heights, i, heights[0].Length - 1, 0, atlantic, visited);

        for (int j = 0; j < heights[0].Length; j++)
            DFS(heights, heights.Length - 1, j, 0, atlantic, visited);

        var result = new List<List<int>>();
        for (int i = 0; i < heights.Length; i++) 
        {
            for (int j = 0; j < heights[0].Length; j++)
            {
                if (pacific.Contains((i, j)) && atlantic.Contains((i, j)))
                {
                    var list = new List<int>();
                    list.Add(i);
                    list.Add(j);
                    result.Add(list);
                }
            }
        }

        return result;
    }

    private void DFS(int[][] heights, int i, int j, int prev, HashSet<(int, int)> ocean, bool[,] visited)
    {
        if (i < 0 || i >= heights.Length || j < 0 || j >= heights[0].Length) return;
        if (visited[i, j] || heights[i][j] < prev) return;
    
        ocean.Add((i, j));
        visited[i, j] = true;

        DFS(heights, i + 1, j, heights[i][j], ocean, visited);
        DFS(heights, i - 1, j, heights[i][j], ocean, visited);
        DFS(heights, i, j + 1, heights[i][j], ocean, visited);
        DFS(heights, i, j - 1, heights[i][j], ocean, visited); 
    }
}
