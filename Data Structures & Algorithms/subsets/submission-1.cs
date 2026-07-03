public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        
        var total = new List<List<int>>();
        total.Add(new List<int>());

        DFS(0, nums, new List<int>(), total);

        return total;         
    }

    private void DFS(int i, int[] nums, List<int> list, List<List<int>> total)
    {
        if (i == nums.Length) return;

        var l1 = list.ToList();
        var l2 = list.ToList();

        l1.Add(nums[i]);
        total.Add(l1);
        
        DFS(i + 1, nums, l1, total);
        DFS(i + 1, nums, l2, total);
    }  
}
