public class Solution {
    public List<List<int>> Permute(int[] nums)
    {
        var total = new List<List<int>>();
        var visited = new bool[nums.Length];     
        DFS(nums, visited, new List<int>(), total);

        return total;    
    }

    private void DFS(int[] nums, bool[] visited, List<int> list, List<List<int>> total)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (visited[i]) continue;

            list.Add(nums[i]);
            visited[i] = true;

            DFS(nums, visited, list.ToList<int>(), total);

            list.RemoveAt(list.Count - 1);
            visited[i] = false;
        }

        if (list.Count == nums.Length) total.Add(list);
    }

}