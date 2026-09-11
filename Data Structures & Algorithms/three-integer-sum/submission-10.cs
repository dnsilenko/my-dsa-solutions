public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<List<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            int j = i + 1, k = nums.Length - 1;
            int target = -nums[i];

            if (i > 0 && nums[i] == nums[i - 1]) continue;

            while (j < k)
            {
                if (nums[j] + nums[k] < target) j++;
                else if (nums[j] + nums[k] > target) k--;
                else
                {
                    if (result.Count > 0)
                    {
                        var li = result[result.Count - 1];
                        if (li[0] == nums[i] && li[1] == nums[j] && li[2] == nums[k]) 
                        {
                            j++; k--;
                            continue;
                        }
                    }

                    var list = new List<int>(); 
                    list.Add(nums[i]);
                    list.Add(nums[j]);
                    list.Add(nums[k]);
                    
                    result.Add(list);

                    j++; k--;
                }
            }
        }                

        return result;  
    }
}
