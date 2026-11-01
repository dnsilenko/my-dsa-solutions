public class Solution
{
    public List<int> SpiralOrder(int[][] matrix)
    {
        int right = matrix[0].Length, down = matrix.Length, left = 0, up = 0;
        var list = new List<int>();

        while (left < right && up < down)
        {
            for (int i = left; i < right; i++) list.Add(matrix[up][i]);     
            up++;

            for (int i = up; i < down; i++) list.Add(matrix[i][right - 1]);         
            right--;

            if (!(left < right && up < down)) break;

            for (int i = right - 1; i >= left; i--) list.Add(matrix[down - 1][i]);
            down--;

            for (int i = down - 1; i >= up; i--) list.Add(matrix[i][left]);
            left++;
        }    

        return list;
    }
}
