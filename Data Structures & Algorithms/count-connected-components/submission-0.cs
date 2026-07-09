public class Solution {
    public int CountComponents(int n, int[][] edges)
    {
        var list = new List<List<int>>();
        var visited = new bool[n];

        for (int i = 0; i < n; i++) list.Add(new List<int>());
        foreach (var edge in edges)
        {
            list[edge[0]].Add(edge[1]);
            list[edge[1]].Add(edge[0]);
        }    

        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            if (!visited[i])
            {
                DFS(list, visited, i);
                counter++;
            }
        }

        return counter;
    }

    private void DFS(List<List<int>> list, bool[] visited, int number)
    {
        if (visited[number]) return;

        visited[number] = true; 
        foreach (var num in list[number]) DFS(list, visited, num);
    }
}