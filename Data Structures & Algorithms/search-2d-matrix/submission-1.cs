public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var array = new int[matrix.Length];
        for (int i = 0; i < matrix.Length; i++)
        {
            array[i] = matrix[i][0];
        }

        int index = BS(array, target);
        int number = BS(matrix[index], target);

        return matrix[index][number] == target;
    }

    private int BS(int[] array, int target)
    {
        int l = 0, r = array.Length - 1, mid = (l + r) / 2;
        while (l <= r)
        {
            if (array[mid] < target) l = mid + 1;
            else if (array[mid] > target) r = mid - 1;
            else break;

            mid = (l + r) / 2;
        }

        return mid;
    }
}