public class Solution
{
    int[] memo;
    public int LengthOfLIS(int[] nums)
    {
        memo = new int[nums.Length];
        Array.Fill(memo, -1);

        for (int i = 0; i < nums.Length; i++)
            DFS(nums, i, int.MinValue);

        return memo.Max() + 1;
    }

    private int DFS(int[] nums, int i, int prev)
    {
        if (i == nums.Length) return 0;
        if (memo[i] != -1) return memo[i];
        if (nums[i] <= prev) return -1;
        
        int max = 0;
        for (int j = i + 1; j < nums.Length; j++)
            max = Math.Max(max, DFS(nums, j, nums[i]) + 1);

        memo[i] = max;
        return max;
    } 
}
