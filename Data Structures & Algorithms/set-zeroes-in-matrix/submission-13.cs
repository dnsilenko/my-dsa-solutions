public class Solution
{
    public void SetZeroes(int[][] matrix)   
    {
        bool rowZero = false;

        for (int i = 0; i < matrix.Length; i++)   
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == 0) // позначення: які рядки/колонки занулити
                {
                    matrix[0][j] = 0; // занулення колонки
                    if (i > 0) matrix[i][0] = 0; // занулення рядка
                    else rowZero = true; // позначення: у нульовому рядку є нуль
                }  
            }    
        }      

        for (int i = 1; i < matrix.Length; i++) 
            for (int j = 1; j < matrix[0].Length; j++)
                if (matrix[i][0] == 0 || matrix[0][j] == 0) matrix[i][j] = 0; // занулення

        if (matrix[0][0] == 0) for (int i = 0; i < matrix.Length; i++) matrix[i][0] = 0;
        if (rowZero) for (int j = 0; j < matrix[0].Length; j++) matrix[0][j] = 0;
    }
}
