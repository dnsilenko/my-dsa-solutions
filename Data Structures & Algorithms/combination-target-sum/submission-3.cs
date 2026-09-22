public class Solution
{
    public List<List<int>> CombinationSum(int[] nums, int target)
    {
        Array.Sort(nums);
        var result = new List<List<int>>();
        DFS(nums, target, 0, result, new List<int>());

        return result;
    }

    private void DFS(int[] nums, int target, int i, List<List<int>> result, List<int> list)
    {
        if (i >= nums.Length) return;
        if (target - nums[i] < 0) return;

        if (target - nums[i] >= 0) list.Add(nums[i]);
        if (target - nums[i] == 0) 
        {
            result.Add(list);
            return;
        }

        DFS(nums, target - nums[i], i, result, list.ToList());
        list.RemoveAt(list.Count - 1);
        DFS(nums, target, i + 1, result, list.ToList());
    }
}
