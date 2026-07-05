public class Solution {
    public bool Exist(char[][] board, string word)
    {
        var visited = new bool[board.Length, board[0].Length];
        for (int r = 0; r < board.Length; r++)
        {
            for (int c = 0; c < board[0].Length; c++)
            {
                if (DFS(visited, r, c, 0, string.Empty, board, word)) return true;
            }
        }

        return false;
    }

    private bool DFS(bool[,] visited, int r, int c, int i, string now, char[][] board, string word)
    {
        if (r >= board.Length || c >= board[0].Length ||
            r < 0 || c < 0 || i >= word.Length || visited[r, c]) return false;
        
        if (board[r][c] != word[i]) return false; 
        else now += board[r][c];
        
        visited[r, c] = true;
        if (now == word) return true;
        
        if (DFS(visited, r + 1, c, i + 1, now, board, word) ||
            DFS(visited, r - 1, c, i + 1, now, board, word) ||
            DFS(visited, r, c + 1, i + 1, now, board, word) ||
            DFS(visited, r, c - 1, i + 1, now, board, word)) return true;

        visited[r, c] = false;

        return false;
    }
}
