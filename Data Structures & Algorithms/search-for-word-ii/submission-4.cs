public class TrieNode
{
    public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
    public bool end = false;
}

public class Solution
{
    public List<string> FindWords(char[][] board, string[] words)
    {
        var root = new TrieNode();
        foreach (string w in words)
        {
            var current = root;

            foreach (char ch in w)
            {
                if (!current.children.ContainsKey(ch))
                    current.children[ch] = new TrieNode();

                current = current.children[ch];     
            }

            current.end = true;
        }      
        
        var visited = new bool[board.Length][];
        for (int i = 0; i < board.Length; i++)
            visited[i] = new bool[board[0].Length];

        var hs = new HashSet<string>();
        for (int i = 0; i < board.Length; i++)
            for (int j = 0; j < board[0].Length; j++)
                DFS(root, board, i, j, hs, visited, new StringBuilder());

        return hs.ToList();
    }
    
    private void DFS(TrieNode prev, char[][] board, int i, int j,
        HashSet<string> hs, bool[][] visited, StringBuilder sb)
    {
        if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length) return;
        if (visited[i][j] || !prev.children.ContainsKey(board[i][j])) return;

        visited[i][j] = true;
        char ch = board[i][j];

        sb.Append(ch);
        prev = prev.children[ch];
        if (prev.end && !hs.Contains(sb.ToString())) hs.Add(sb.ToString());

        DFS(prev, board, i + 1, j, hs, visited, sb);
        DFS(prev, board, i - 1, j, hs, visited, sb);
        DFS(prev, board, i, j + 1, hs, visited, sb);
        DFS(prev, board, i, j - 1, hs, visited, sb);

        visited[i][j] = false;
        sb.Remove(sb.ToString().Length - 1, 1);
    }
}












