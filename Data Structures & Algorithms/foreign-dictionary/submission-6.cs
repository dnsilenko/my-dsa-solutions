public class Solution
{
    public string foreignDictionary(string[] words)
    {
        var dict = new Dictionary<char, HashSet<char>>();    
        foreach (var word in words)
            foreach (var w in word)
                dict[w] = new HashSet<char>();

        for (int i = 1; i < words.Length; i++)
        {
            string word1 = words[i - 1];
            string word2 = words[i];
            int min = Math.Min(word1.Length, word2.Length);

            if (word1.Length > word2.Length &&
                word1.Substring(0, min) == word2.Substring(0, min))   
            {
                return string.Empty;    
            }

            for (int j = 0; j < min; j++)
            {
                if (word1[j] != word2[j])
                {
                    dict[word1[j]].Add(word2[j]);
                    break;
                }
            } 
        }

        var visited = new Dictionary<char, bool>();
        var list = new List<char>();

        foreach (var symbol in dict.Keys)
        {
            bool result = DFS(symbol, dict, visited, list);     
            if (result) return string.Empty;    
        }

        list.Reverse();
        var sb = new StringBuilder();

        foreach (var item in list)
        {
            sb.Append(item);
        }

        return sb.ToString();
    }

    private bool DFS(char ch, Dictionary<char, HashSet<char>> dict,
        Dictionary<char, bool> visited, List<char> list)
    {
        if (visited.ContainsKey(ch)) return visited[ch];

        visited[ch] = true;
        foreach (var symbol in dict[ch])
        {
            bool result = DFS(symbol, dict, visited, list);
            if (result) return true;
        }

        list.Add(ch);        
        visited[ch] = false;
        return false;
    }
}

















