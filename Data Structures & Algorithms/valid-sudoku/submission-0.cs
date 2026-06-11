public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for (int i = 0; i < board.Length; i++)
        {
            var seen = new HashSet<char>();
            for (int j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] == '.') continue;
                if (seen.Contains(board[i][j])) return false;
                seen.Add(board[i][j]);
            }
        }

        for (int i = 0; i < board.Length; i++)
        {
            var seen = new HashSet<char>();
            for (int j = 0; j < board[i].Length; j++)
            {
                if (board[j][i] == '.') continue;
                if (seen.Contains(board[j][i])) return false;
                seen.Add(board[j][i]);
            }
        }

        for (int square = 0; square < 9; square++)
        {
            var seen = new HashSet<char>();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int row = (square / 3) * 3 + i;
                    int col = (square % 3) * 3 + j;

                    if (board[row][col] == '.') continue;
                    if (seen.Contains(board[row][col])) return false;
                    seen.Add(board[row][col]);
                }
            }
        }
        
        return true;
    }
}
