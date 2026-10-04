public class Solution
{
    public int[] memo = null;

    public int Rob(int[] nums)
    {
        memo = new int[nums.Length];

        return DFS(nums, 0);
    }

    private int DFS(int[] nums, int i)
    {
        if (i >= nums.Length) return 0;
        if (memo[i] != 0) return memo[i];

        memo[i] = Math.Max(nums[i] + DFS(nums, i + 2), DFS(nums, i + 1));
        return memo[i];
    }
}
