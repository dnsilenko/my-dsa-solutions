public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var result = new int[2];
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(target - nums[i]))
            {
                result[0] = dict[target - nums[i]];
                result[1] = i;

                break;
            }
            else dict[nums[i]] = i;
        }

        return result;
    }
}
