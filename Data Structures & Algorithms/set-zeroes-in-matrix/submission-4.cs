public class Solution
{
    public void SetZeroes(int[][] matrix)
    {
        var hs = new HashSet<(int, int)>();
        for (int i = 0; i < matrix.Length; i++)
            for (int j = 0; j < matrix[0].Length; j++)
                if (matrix[i][j] == 0)
                    hs.Add((i, j));

        foreach (var tuple in hs)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                matrix[tuple.Item1][j] = 0;
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i][tuple.Item2] = 0;
            }
        }   
    }
}
