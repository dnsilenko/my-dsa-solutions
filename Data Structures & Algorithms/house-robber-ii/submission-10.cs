public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 1) return nums[0];

        var memo1 = new int[nums.Length];          
        var memo2 = new int[nums.Length];        

        Array.Fill(memo1, -1);
        Array.Fill(memo2, -1);

        int current = Go(nums, 0, memo1, true);
        int skip = Go(nums, 1, memo2, false);

        return Math.Max(current, skip);
    }

    private int Go(int[] nums, int i, int[] memo, bool toPrevEnd)
    {
        if ((toPrevEnd && i >= nums.Length - 1) || i >= nums.Length) return 0;
        if (memo[i] != -1) return memo[i];

        memo[i] = Math.Max(nums[i] + Go(nums, i + 2, memo, toPrevEnd), Go(nums, i + 1, memo, toPrevEnd));
        return memo[i];
    }
}
