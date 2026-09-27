public class Solution
{
    public Dictionary<int, List<int>> nodes = new Dictionary<int, List<int>>();
    public HashSet<int> visiting = new HashSet<int>();

    public bool ValidTree(int n, int[][] edges)
    {
        for (int i = 0; i < n; i++)
            nodes[i] = new List<int>();

        foreach (var edge in edges)
        {
            nodes[edge[0]].Add(edge[1]);
            nodes[edge[1]].Add(edge[0]);
        }

        if (!DFS(0, -1)) return false;
        return visiting.Count == n;  
    }

    private bool DFS(int node, int parent)
    {
        if (visiting.Contains(node)) return false;
        visiting.Add(node);

        foreach (int child in nodes[node])
        {
            if (child == parent) continue;
            if (!DFS(child, node)) return false;
        }

        return true;
    }
}
