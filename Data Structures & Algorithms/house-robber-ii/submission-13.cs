public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 1) return nums[0];

        var memo1 = new int[nums.Length];    
        var memo2 = new int[nums.Length];

        Array.Fill(memo1, -1);
        Array.Fill(memo2, -1);

        int current = DFS(nums, 0, memo1, true);
        int skip = DFS(nums, 1, memo2, false);

        return Math.Max(current, skip);
    }

    private int DFS(int[] nums, int i, int[] memo, bool prevEnd)
    {   
        if (prevEnd && i >= nums.Length - 1 || i >= nums.Length) return 0;
        if (memo[i] != -1) return memo[i];

        memo[i] = Math.Max(nums[i] + DFS(nums, i + 2, memo, prevEnd), DFS(nums, i + 1, memo, prevEnd));
        return memo[i];
    }
}
