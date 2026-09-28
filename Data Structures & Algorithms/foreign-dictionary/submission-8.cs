public class Solution
{
    public Dictionary<char, HashSet<char>> graph = new Dictionary<char, HashSet<char>>();
    public Dictionary<char, bool> visiting = new Dictionary<char, bool>();
    public List<char> result = new List<char>();

    public string foreignDictionary(string[] words)
    {   
        foreach (string word in words) // символ : символи, що йдуть після нього (у алфавіті)
            foreach (char w in word)
                if (!graph.ContainsKey(w)) graph[w] = new HashSet<char>();

        for (int i = 1; i < words.Length; i++)
        {
            string w1 = words[i - 1], w2 = words[i];
            int length = Math.Min(w1.Length, w2.Length); // довжина меншого слова            

            if (w1.Length > w2.Length && // якщо сортування некоректне
                w1.Substring(0, length) == w2.Substring(0, length)) return string.Empty;

            for (int j = 0; j < length; j++) // проходимось по меншому слову 
                if (w1[j] != w2[j])
                {
                    graph[w1[j]].Add(w2[j]); // додаємо, що після w1[j] йде w2[j]
                    break; // 
                }
        }
    
        foreach (char ch in graph.Keys) if (DFS(ch)) return string.Empty;

        result.Reverse(); 
        var sb = new StringBuilder();
        foreach (char ch in result) sb.Append(ch);

        return sb.ToString();
    }

    private bool DFS(char ch)
    {
        if (visiting.ContainsKey(ch)) return visiting[ch];

        visiting[ch] = true;
        foreach (char next in graph[ch]) if (DFS(next)) return true;

        visiting[ch] = false;
        result.Add(ch);
        return false;   
    }
}
