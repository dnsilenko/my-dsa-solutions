public class Solution {
    public bool ValidTree(int n, int[][] edges)
    {
        if (edges.Length == 0) return true;
        
        var dict = new Dictionary<int, List<int>>();
        foreach (var pair in edges)
        {
            if (!dict.ContainsKey(pair[0]))
            {
                var list = new List<int>();
                list.Add(pair[1]);

                dict[pair[0]] = list;
            }
            else dict[pair[0]].Add(pair[1]);

            if (!dict.ContainsKey(pair[1]))
            {
                var list = new List<int>();
                list.Add(pair[0]);

                dict[pair[1]] = list;
            }
            else dict[pair[1]].Add(pair[0]);
        }

        var visited = new bool[n];
        bool dfs = DFS(dict, 0, visited, -1);
    
        if (!dfs) return false;
        for (int i = 0; i < n; i++) if (!visited[i]) return false;
        
        return true;
    }

        private bool DFS(Dictionary<int, List<int>> dict, int number, bool[] visited, int prev)
        {
            if (visited[number]) return false;

            visited[number] = true; 
            foreach (var num in dict[number])
                if (num != prev && !DFS(dict, num, visited, number)) return false;

            return true;
        }
}
