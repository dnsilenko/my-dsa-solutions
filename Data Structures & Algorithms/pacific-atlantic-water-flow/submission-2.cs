public class Solution {
    public List<List<int>> PacificAtlantic(int[][] heights) 
    {                             
        var result = new List<List<int>>();
        var pacific = new bool[heights.Length, heights[0].Length];
        var atlantic = new bool[heights.Length, heights[0].Length];

        for (int i = 0; i < heights.Length; i++) // row
        {
            DFS(i, 0, pacific, heights, int.MinValue);
            DFS(heights.Length - 1 - i, heights[0].Length - 1, atlantic, heights, int.MinValue);
        }

        for (int i = 0; i < heights[0].Length; i++) // column
        {
            DFS(0, i, pacific, heights, int.MinValue);
            DFS(heights.Length - 1, heights[0].Length - 1 - i, atlantic, heights, int.MinValue);
        }     

        for (int i = 0; i < heights.Length; i++)
        {
            for (int j = 0; j < heights[0].Length; j++)
            {
                if (pacific[i, j] && atlantic[i, j]) 
                {
                    var list = new List<int>();
                    list.Add(i); list.Add(j);
                    result.Add(list);
                }
            }
        }

        return result;
    }   

    private void DFS(int r, int c, bool[,] ocean, int[][] heights, int prev)
    {
        if (r < 0 || r >= heights.Length || c < 0 || c >= heights[0].Length ||
        ocean[r, c] || heights[r][c] < prev) return;

        ocean[r, c] = true;
        DFS(r + 1, c, ocean, heights, heights[r][c]);
        DFS(r - 1, c, ocean, heights, heights[r][c]);
        DFS(r, c + 1, ocean, heights, heights[r][c]);
        DFS(r, c - 1, ocean, heights, heights[r][c]); 
    }
}            