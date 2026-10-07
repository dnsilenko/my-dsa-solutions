public class Solution
{
    public int[] memo;

    public int Rob(int[] nums)
    {
        memo = new int[nums.Length];
        return Go(nums, 0);
    }

    private int Go(int[] nums, int i)
    {
        if (i >= nums.Length) return 0;
        if (memo[i] != 0) return memo[i];

        memo[i] = Math.Max(nums[i] + Go(nums, i + 2), Go(nums, i + 1));
        return memo[i];
    }
}
