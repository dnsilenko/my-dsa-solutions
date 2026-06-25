    
    public class TrieNode
    {
        public TrieNode[] children { get; set; } = new TrieNode[26];
        public bool end { get; set; } = false;
    }

public class PrefixTree
{
    private TrieNode _root;
    public PrefixTree()
    {
        _root = new TrieNode();
    }
    
    public void Insert(string word) {
        if (string.IsNullOrWhiteSpace(word)) return;

        var current = _root;
        foreach (var sym in word)
        {
            int idx = sym - 'a';

            if (current.children[idx] is null)
            {
                current.children[idx] = new TrieNode();
            }

            current = current.children[idx];
        }

        current.end = true;
    }
    
    public bool Search(string word) {
        if (string.IsNullOrWhiteSpace(word)) return false;

        var current = _root;
        foreach (var sym in word)
        {
            int idx = sym - 'a';
            if (current.children[idx] is null) return false;

            current = current.children[idx];
        }          

        return current.end;
    }
    
    public bool StartsWith(string prefix) {
        if (string.IsNullOrWhiteSpace(prefix)) return false;

        var current = _root;
        foreach (var sym in prefix)
        {
            int idx = sym - 'a';
            if (current.children[idx] is null) return false;

            current = current.children[idx];
        }          

        return true;     
    }
}
