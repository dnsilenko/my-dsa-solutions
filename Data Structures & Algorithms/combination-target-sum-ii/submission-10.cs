public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);
        var total = new List<List<int>>(); 
        DFS(0, 0, candidates, target, new List<int>(), total);

        return total;
    }

    private void DFS(int start, int sum, int[] candidates, int target, List<int> list, List<List<int>> total)
    {
        if (target == 0) // означає: сума вже дорівнює початковому target 
        {
            total.Add(list); 
            return;
        }
        
        for (int i = start; i < candidates.Length; i++) // 
        {   
            if (i > start && candidates[i] == candidates[i - 1]) continue;
            else if (candidates[i] > target) break;

            list.Add(candidates[i]);
            DFS(i + 1, sum, candidates, target - candidates[i], list.ToList(), total);
            
            list.RemoveAt(list.Count - 1);
        }        
    }

}
