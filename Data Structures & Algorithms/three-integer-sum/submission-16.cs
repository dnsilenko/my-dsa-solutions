public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<List<int>>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            int target = -nums[i];
            int j = i + 1, k = nums.Length - 1;

            if (i > 0 && nums[i - 1] == nums[i]) continue;

            while (j < k)
            {
                var list = new List<int>();

                if (nums[j] + nums[k] == target)
                {
                    list.Add(nums[i]);        
                    list.Add(nums[j]);
                    list.Add(nums[k]);

                    j++; k--;

                    while (k >= 0 && nums[k] == nums[k + 1]) k--;
                    while (j < nums.Length && nums[j - 1] == nums[j]) j++;
                }
                else if (nums[j] + nums[k] > target) k--;
                else if (nums[j] + nums[k] < target) j++;

                if (list.Count > 0) result.Add(list);
            }
        }

        return result;
    }
}
