public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates); var total = new List<List<int>>(); 
        DFS(0, 0, candidates, target, new List<int>(), total);

        return total;
    }

    private void DFS(int i, int sum, int[] candidates, int target, List<int> list, List<List<int>> total)
    {
        if (target == 0) 
        {
            total.Add(list);
            return;
        }
        
        for (int j = i; j < candidates.Length; j++)
        {   
            if (j > i && candidates[j] == candidates[j - 1]) continue;

            if (candidates[j] > target) break;

            list.Add(candidates[j]);
            DFS(j + 1, sum, candidates, target - candidates[j], list.ToList(), total);
            list.RemoveAt(list.Count - 1);
        }
    }
}
