public class Solution
{
    int[] memo;
    public int LengthOfLIS(int[] nums)
    {
        int max = 0;
        memo = new int[nums.Length];
        Array.Fill(memo, -1);

        for (int i = 0; i < nums.Length; i++)
        {
            max = Math.Max(max, DFS(nums, i, int.MinValue)); 
        }
        return max + 1;
    }

    private int DFS(int[] nums, int i, int prev)
    {
        if (i >= nums.Length) return 0;
        if (memo[i] != -1) return memo[i];

        int max = 0;
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] >= nums[j]) continue;
            max = Math.Max(max, DFS(nums, j, nums[i]) + 1);
        }

        memo[i] = max;
        return max;
    }
}
