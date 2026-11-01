public class Solution
{
    public List<int> SpiralOrder(int[][] matrix)
    {
        int i = 0, j = 0;
        int right = matrix[0].Length, down = matrix.Length, left = 0, up = 1;
        var list = new List<int>();

        while (list.Count < matrix.Length * matrix[0].Length)
        {
            while (j < right)
            {
                list.Add(matrix[i][j]);
                j++;
            }       

            j--; i++; right--; 

            while (list.Count < matrix.Length * matrix[0].Length && i < down)
            {
                list.Add(matrix[i][j]);
                i++;
            }     

            i--; j--; down--;

            while (list.Count < matrix.Length * matrix[0].Length && j >= left)
            {
                list.Add(matrix[i][j]);
                j--;
            }

            j++; i--; left++;

            while (list.Count < matrix.Length * matrix[0].Length && i >= up)
            {
                list.Add(matrix[i][j]);
                i--;  
            }

            i++; j++; up++;
        }    

        return list;
    }
}
