public class Solution
{
    public void Rotate(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
            for (int j = i + 1; j < matrix.Length; j++)
                (matrix[j][i], matrix[i][j]) = (matrix[i][j], matrix[j][i]);
            
        for (int i = 0; i < matrix.Length; i++)
            for (int j = 0, k = matrix.Length - 1; j < k; j++, k--)
                (matrix[i][j], matrix[i][k]) = (matrix[i][k], matrix[i][j]);
    }
}
