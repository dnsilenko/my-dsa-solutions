public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 1) return nums[0];

        var memo1 = new int[nums.Length];
        var memo2 = new int[nums.Length];
        
        Array.Fill(memo1, -1);
        Array.Fill(memo2, -1);

        DFS(nums, 0, true, memo1);
        DFS(nums, 1, false, memo2);

        return Math.Max(memo1[0], memo2[1]);
    }

    private int DFS(int[] nums, int i, bool toPrevEnd, int[] memo)
    {
        if (toPrevEnd && i >= nums.Length - 1) return 0;
        if (i >= nums.Length) return 0;
        if (memo[i] != -1) return memo[i];

        memo[i] = Math.Max(nums[i] + DFS(nums, i + 2, toPrevEnd, memo), 
            DFS(nums, i + 1, toPrevEnd, memo));
        return memo[i];
    }
}
