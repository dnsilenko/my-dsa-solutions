public class Solution {
    public int Rob(int[] nums)
    {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0]; 

        var dp = new int[nums.Length];
        dp[0] = nums[0];
        dp[1] = Math.Max(nums[1], nums[0]);

        for (int i = 2; i < nums.Length; i++)
            dp[i] = Math.Max(nums[i] + dp[i - 2], dp[i - 1]);

        return dp[dp.Length - 1];
    }
}
