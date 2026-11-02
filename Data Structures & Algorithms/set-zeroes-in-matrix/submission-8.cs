public class Solution
{
    public void SetZeroes(int[][] matrix)
    {
        bool rowZero = false;
        bool colZero = false;

        for (int i = 0; i < matrix.Length && !rowZero; i++)
            if (matrix[i][0] == 0) rowZero = true;

        for (int j = 0; j < matrix[0].Length && !colZero; j++)
            if (matrix[0][j] == 0) colZero = true;

        for (int i = 1; i < matrix.Length; i++)
        {
            for (int j = 1; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }         
            }
        }               

        for (int i = 1; i < matrix.Length; i++) 
            if (matrix[i][0] == 0) for (int j = 1; j < matrix[0].Length; j++) matrix[i][j] = 0;

        for (int j = 1; j < matrix[0].Length; j++) 
            if (matrix[0][j] == 0) for (int i = 1; i < matrix.Length; i++) matrix[i][j] = 0;

        if (rowZero) for (int i = 0; i < matrix.Length; i++) matrix[i][0] = 0;

        if (colZero) for (int j = 0; j < matrix[0].Length; j++) matrix[0][j] = 0;
    }
}
