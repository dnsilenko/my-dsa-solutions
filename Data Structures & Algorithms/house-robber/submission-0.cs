public class Solution {
    public int Rob(int[] nums)
    {
        int rob1 = 0, rob2 = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int max = Math.Max(nums[i] + rob1, rob2);
            rob1 = rob2;
            rob2 = max;
        }

        return rob2;
    }
}
