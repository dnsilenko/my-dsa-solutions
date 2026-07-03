public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        var total = new List<List<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            DFS(i, nums, 0, target, new List<int>(), total);
        }
               
        return total; 
    } 

    private void DFS(int i, int[] nums, int sum, int target, List<int> list, List<List<int>> total)
    {
        if (i == nums.Length) return;

        DFS(i + 1, nums, sum, target, list.ToList(), total);

        sum += nums[i];
        if (sum > target) return;

        if (sum <= target) list.Add(nums[i]);
        if (sum == target)
        {
            if (IsUnique(list, total)) total.Add(list);

            return;
        }

        DFS(i, nums, sum, target, list.ToList(), total);
        DFS(i + 1, nums, sum, target, list.ToList(), total);
    }

    private bool IsUnique(List<int> list, List<List<int>> total)
    {
        foreach (var li in total)
        {
            if (li.Count != list.Count) continue;  

            bool dublicate = true;
            for (int i = 0; i < li.Count; i++)
            {
                if (li[i] != list[i])
                {
                    dublicate = false;
                    break;
                }
            }   

            if (dublicate) return false; 
        }  

        return true;
    }
}
