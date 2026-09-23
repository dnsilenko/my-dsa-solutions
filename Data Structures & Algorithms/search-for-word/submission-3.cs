public class Solution
{
    public bool Exist(char[][] board, string word)
    {
        var visited = new bool[board.Length][];
        for (int i = 0; i < board.Length; i++)
            visited[i] = new bool[board[0].Length];

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (DFS(board, word, 0, i, j, visited)) return true;
            }    
        }

        return false;            
    }

    private bool DFS(char[][] board, string word, int index, int i, int j, bool[][] visited)
    {
        if (index >= word.Length) return true;
        if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length) return false;
        if (visited[i][j] || word[index] != board[i][j]) return false;

        visited[i][j] = true;
        bool left = DFS(board, word, index + 1, i, j - 1, visited);
        bool right = DFS(board, word, index + 1, i, j + 1, visited);
        bool up = DFS(board, word, index + 1, i - 1, j, visited);
        bool down = DFS(board, word, index + 1, i + 1, j, visited);
        visited[i][j] = false;

        if (left || right || up || down) return true;
        return false;
    }   
}
