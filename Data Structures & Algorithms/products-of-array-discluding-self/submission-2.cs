public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var prefix = new int[nums.Length];
        prefix[0] = nums[0];

        var suffix = new int[nums.Length];
        suffix[nums.Length - 1] = nums[nums.Length - 1];

        for (int i = 1; i < nums.Length; i++)
            prefix[i] = nums[i] * prefix[i - 1];      

        for (int i = nums.Length - 2; i >= 0; i--)
            suffix[i] = nums[i] * suffix[i + 1]; 

        var result = new int[nums.Length];
        result[nums.Length - 1] = prefix[nums.Length - 2];
        result[0] = suffix[1];

        for (int i = 1; i < nums.Length - 1; i++)
            result[i] = prefix[i - 1] * suffix[i + 1];

        return result;
    }
}
