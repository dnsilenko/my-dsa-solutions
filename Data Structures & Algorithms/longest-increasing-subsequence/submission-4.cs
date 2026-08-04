public class Solution
{
    public int LengthOfLIS(int[] nums)
    {
        int[] memo = new int[nums.Length];
        Array.Fill(memo, -1);

        int max = 0;
        for (int i = 0; i < nums.Length; i++)
            max = Math.Max(max, DFS(i, nums, memo));          

        return max;
    }

    private int DFS(int i, int[] nums, int[] memo)
    {
        if (memo[i] != -1) return memo[i];

        int max = 1;
        for (int j = i + 1; j < nums.Length; j++)
            if (nums[j] > nums[i]) max = Math.Max(max, 1 + DFS(j, nums, memo));

        memo[i] = max; return max;
    }
}
