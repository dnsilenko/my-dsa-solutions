public class TrieNode
{
    public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
    public bool end = false;
}

public class WordDictionary
{
    public TrieNode _root;

    public WordDictionary()
    {
        _root = new TrieNode();
    }
    
    public void AddWord(string word)
    {
        var current = _root;
        foreach (char w in word)
        {
            if (!current.children.ContainsKey(w))
                current.children[w] = new TrieNode();

            current = current.children[w];     
        }    

        current.end = true;
    }
    
    public bool Search(string word)
    {
        return DFS(_root, word, 0);
    }

    private bool DFS(TrieNode current, string word, int index)
    {
        if (index >= word.Length) return current.end;
 
        if (word[index] != '.')
        {
            if (!current.children.ContainsKey(word[index])) return false;

            return DFS(current.children[word[index]], word, index + 1);
        }

        foreach (var key in current.children.Keys)
            if (DFS(current.children[key], word, index + 1)) return true;

        return false;
    }
}
