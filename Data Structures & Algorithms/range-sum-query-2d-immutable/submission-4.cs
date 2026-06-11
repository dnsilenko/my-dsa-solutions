public class NumMatrix {

    private int[][] prefix;
    public NumMatrix(int[][] matrix) {

        prefix = new int[matrix.Length + 1][];
        for (int i = 0; i <= matrix.Length ; i++) prefix[i] = new int[matrix[0].Length + 1];

        for (int i = 1; i < prefix.Length; i++) 
        {   // із одиниці, бо створили допоміжні -> рядок і стовпець
            for (int j = 1; j < prefix[i].Length; j++)  
            {   // поточний + 
                prefix[i][j] = matrix[i - 1][j - 1] +
                prefix[i][j - 1] + prefix[i - 1][j] - prefix[i - 1][j - 1];
            }
        }

        //return prefix[row2 + 1][col2 + 1] -
        //prefix[row1][col2 + 1] - prefix[row2 + 1][col1] + prefix[row1][col1];
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        return prefix[row2 + 1][col2 + 1] -
        prefix[row1][col2 + 1] - prefix[row2 + 1][col1] + prefix[row1][col1];
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */