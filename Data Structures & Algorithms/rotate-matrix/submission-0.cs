public class Solution
{
    public void Rotate(int[][] matrix)
    {
        for (int i = 0, j = matrix.Length - 1; i < j; i++, j--)
        {
            (matrix[i], matrix[j]) = (matrix[j], matrix[i]); 
        }              

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = i; j < matrix[i].Length; j++)
            {
                (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
            }
        }              
    }
}
