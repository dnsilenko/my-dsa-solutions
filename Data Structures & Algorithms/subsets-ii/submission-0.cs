public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums)
    {
        Array.Sort(nums);

        var total = new List<List<int>>();   
        DFS(0, nums, new List<int>(), total);

        return total;    
    }

    private void DFS(int start, int[] nums, List<int> list, List<List<int>> total)
    {
        total.Add(list);
        
        for (int i = start; i < nums.Length; i++)
        {
            if (i > start && nums[i - 1] == nums[i]) continue;

            list.Add(nums[i]);
            DFS(i + 1, nums, list.ToList<int>(), total);

            list.RemoveAt(list.Count - 1);
        } 
    }

























    private bool Unique(List<int> list, List<List<int>> total)
    {
        foreach (var item in total)
        {
            if (item.Count != list.Count) continue; 

            bool unique = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != item[i]) 
                {
                    unique = true;
                    break;
                }
            }

            if (!unique) return false;
        }

        return true;
    }
}
