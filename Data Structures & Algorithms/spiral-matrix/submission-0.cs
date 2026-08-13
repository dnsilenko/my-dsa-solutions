public class Solution
{
    public List<int> SpiralOrder(int[][] matrix) 
    {
        var list = new List<int>();
        int count = matrix.Length * matrix[0].Length;
        
        int i = 0, j = 0;
        int right = matrix[0].Length, down = matrix.Length, left = 0, up = 0;

        while (list.Count < count)
        {
            while (j < right)
            {
                list.Add(matrix[i][j]);
                j++;
            }

            j--;
            i++;
            right--;
            if (list.Count >= count) break;

            while (i < down)
            {
                list.Add(matrix[i][j]);
                i++;
            }

            i--;
            j--;
            down--;
            if (list.Count >= count) break;

            while (j >= left)
            {
                list.Add(matrix[i][j]);
                j--;
            }

            j++;
            i--;
            left++;
            if (list.Count >= count) break;

            while (i > up)
            {
                list.Add(matrix[i][j]);
                i--;
            } 

            i++;
            j++;
            up++;
        }

        return list;
    }
}
