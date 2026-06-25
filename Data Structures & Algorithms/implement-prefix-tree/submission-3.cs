    
    public class TrieNode
    {
        // посилання на наступні вузли (якщо немає -> слово не додано)
        public TrieNode[] children { get; set; }

        // чи являє поточний вузол слово (але це не кінець шляху) 
        public bool end { get; set; } 

        public TrieNode()
        {
            children = new TrieNode[26]; // capacity == 26 (кількість літер)    
            end = false; 
        }
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
        var current = _root; // посилаємо current на root
        foreach (var sym in word) // перебираємо слово
        {
            int idx = sym - 'a'; // індекс у масиві

            // якщо null -> значить символ ще не додано
            if (current.children[idx] is null) 
            {
                current.children[idx] = new TrieNode();
            }

            current = current.children[idx]; // йдемо глибше 
        }

        current.end = true; // маркер, що слово додано
    }
    
    public bool Search(string word)
    {
        var current = _root;
        foreach (var sym in word)
        {
            int idx = sym - 'a';
            if (current.children[idx] is null) return false;

            current = current.children[idx];
        }          

        return current.end;
    }
    
    public bool StartsWith(string prefix)
    {
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
