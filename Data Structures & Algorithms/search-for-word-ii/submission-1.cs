public class Solution
{
    private class TrieNode
    {
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        public bool end = false;
    
        public void AddWord(TrieNode root, string word)
        {
            var current = this;
            foreach (var symbol in word)
            {
                if (!current.children.ContainsKey(symbol))
                    current.children[symbol] = new TrieNode();

                current = current.children[symbol];
            }

            current.end = true;
        }
    }

    private HashSet<string> result = new HashSet<string>();
    private bool[,] visited;

    public List<string> FindWords(char[][] board, string[] words)
    {
        var root = new TrieNode();
        for (int i = 0; i < words.Length; i++)
        {
            root.AddWord(root, words[i]);
        }

        visited = new bool[board.Length, board[0].Length];  
        for (int r = 0; r < board.Length; r++)
            for (int c = 0; c < board[0].Length; c++) 
                DFS(board, r, c, root, string.Empty);

        return result.ToList();
    }
        private void DFS(char[][] board, int r, int c, TrieNode node, string word)
        {
            if (r < 0 || c < 0 || r >= board.Length || c >= board[0].Length) return;
            if (!node.children.ContainsKey(board[r][c]) || visited[r, c]) return;

            visited[r, c] = true;
            node = node.children[board[r][c]]; 
            word += board[r][c];

            if (node.end) result.Add(word);

            DFS(board, r + 1, c, node, word);
            DFS(board, r - 1, c, node, word);
            DFS(board, r, c + 1, node, word);
            DFS(board, r, c - 1, node, word);

            visited[r, c] = false;
        }
}
