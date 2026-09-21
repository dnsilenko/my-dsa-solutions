public class TrieNode
{
    public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
    public bool end = false;
}

public class PrefixTree
{
    private TrieNode _root;

    public PrefixTree()
    {
        _root = new TrieNode();  
    }
    
    public void Insert(string word)
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
        var current = _root;
        foreach (char w in word)
        {
            if (!current.children.ContainsKey(w)) return false;  

            current = current.children[w];
        } 

        return current.end;
    }
    
    public bool StartsWith(string prefix) 
    {
        var current = _root;
        foreach (char w in prefix)
        {
            if (!current.children.ContainsKey(w)) return false;  

            current = current.children[w];
        } 

        return true;   
    }
}
