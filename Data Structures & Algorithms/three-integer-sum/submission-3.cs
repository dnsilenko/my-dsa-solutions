public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<List<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            int j = i + 1, k = nums.Length - 1; 

            while (j < k)
            {
                var list = new List<int>();
                int target = nums[i] + nums[j] + nums[k];
                
                if (target > 0) k--;
                else if (target < 0) j++;
                else if (target == 0) 
                {
                    list.Add(nums[i]);
                    list.Add(nums[j]);
                    list.Add(nums[k]);
                
                    if (Unique(result, list)) result.Add(list);

                    j++;
                }
            }
        }     

        return result;
    }

    private bool Unique(List<List<int>> result, List<int> list)
    {
        foreach (var item in result)
        {
            if (item[0] == list[0] && item[1] == list[1] && item[2] == list[2])
                return false;
        }

        return true;    
    }
}
