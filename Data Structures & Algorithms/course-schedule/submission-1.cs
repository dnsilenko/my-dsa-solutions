public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        var dict = new Dictionary<int, List<int>>();
        foreach (var pair in prerequisites) 
        {
            if (!dict.ContainsKey(pair[1]))
            {
                var list = new List<int>();
                list.Add(pair[0]);

                dict[pair[1]] = list;
            }
            else dict[pair[1]].Add(pair[0]);
        }      

        var visited = new bool[numCourses];   
        for (int i = 0; i < numCourses; i++)
            if (!DFS(dict, i, visited)) return false;        

        return true;
    }

    private bool DFS(Dictionary<int, List<int>> dict, int number, bool[] vis)
    {
        if (!dict.ContainsKey(number)) return true;
        if (vis[number]) return false;

        vis[number] = true;
        foreach (var num in dict[number]) 
            if (!DFS(dict, num, vis)) return false;

        vis[number] = false;
        return true;
    }   

}
