public class Solution
{
    public Dictionary<int, List<int>> neighs = new Dictionary<int, List<int>>();
    public HashSet<int> visiting = new HashSet<int>();

    public int CountComponents(int n, int[][] edges)
    {
        for (int i = 0; i < n; i++) neighs[i] = new List<int>();

        foreach (var edge in edges)
        {
            neighs[edge[0]].Add(edge[1]);
            neighs[edge[1]].Add(edge[0]);
        }

        int counter = 0;
        for (int i = 0; i < n; i++) 
            if (DFS(i, -1)) counter++;

        return counter;    
    }

    private bool DFS(int node, int parent)
    {
        if (visiting.Contains(node)) return false;
        if (!neighs.ContainsKey(node)) return false;

        visiting.Add(node);

        foreach (int neigh in neighs[node])
        {
            if (neigh == parent) continue;
            DFS(neigh, node);
        }

        neighs.Remove(node);
        return true;
    }
}
