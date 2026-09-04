public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            dict[nums[i]] = i;
        }

        var result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(target - nums[i]) && i != dict[target - nums[i]])
            {
                result[0] = i;
                result[1] = dict[target - nums[i]];

                break;
            }
        }

        return result;
    }
}
