public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        var dict = new Dictionary<int, List<int>>();
        foreach (var pair in prerequisites) 
        {
            if (!dict.ContainsKey(pair[0]))
            {
                var list = new List<int>();
                list.Add(pair[1]);

                dict[pair[0]] = list;
            }
            else dict[pair[0]].Add(pair[1]);
        }      

        var visited = new bool[numCourses];   
        for (int i = 0; i < numCourses; i++)
        {
            if (!DFS(dict, i, visited)) return false;        
        }         

        return true;
    }

    private bool DFS(Dictionary<int, List<int>> dict, int number, bool[] visited)
    {
        if (!dict.ContainsKey(number)) return true;
        if (visited[number]) return false;

        visited[number] = true;
        foreach (var num in dict[number]) 
        {
            if (!DFS(dict, num, visited)) return false;
        }        

        visited[number] = false;
        return true;
    }   
}
