public class WordDictionary {

    private class TrieNode
    {
        public TrieNode[] children { get; set; }
        public bool end { get; set; } 

        public TrieNode()
        {   
            children = new TrieNode[26];
            end = false;
        }
    }

    private TrieNode _root;
    public WordDictionary()
    {
        _root = new TrieNode();
    }
    
    public void AddWord(string word)
    {
        var current = _root;
        foreach (var symbol in word)
        {
            int idx = symbol - 'a';
            if (current.children[idx] is null) 
            {
                current.children[idx] = new TrieNode();    
            }

            current = current.children[idx];
        }        

        current.end = true;   
    }
    
    public bool Search(string word)
    {
        var current = _root;
        return DFS(current.children, current, word, 0);
    }

    private bool DFS(TrieNode[] children, TrieNode node, string word, int index)
    {
        if (index >= word.Length) return node.end; // коли переглянули кожен символ

        if (word[index] == '.') // якщо зустріли крапку
        {
            foreach (var child in children)
            {
                if (child is not null) // то для кожного != null -> DFS 
                {
                    bool dfs = DFS(child.children, child, word, index + 1);
                    if (dfs) return true; // слово знайдено ->  повертаємо true 
                }
            }   

            return false; // інакше -> false
        }
        // якщо не крапка: 
        int idx = word[index] - 'a';
        var next = children[idx]; // наступний вузол

        if (next is null) return false; // 
        return DFS(next.children, next, word, index + 1);
    }

}