public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 0) return 0;
        else if (nums.Length == 1) return nums[0];
        else if (nums.Length == 2) return Math.Max(nums[0], nums[1]);

        var dp1 = new int[nums.Length];
        var dp2 = new int[nums.Length];    
    
        dp1[0] = nums[0];
        dp1[1] = Math.Max(nums[1], nums[0]);
        for (int i = 2; i < nums.Length - 1; i++)
            dp1[i] = Math.Max(nums[i] + dp1[i - 2], dp1[i - 1]);

        dp2[1] = nums[1];
        dp2[2] = Math.Max(nums[2], nums[1]);
        for (int i = 3; i < nums.Length; i++)
            dp2[i] = Math.Max(nums[i] + dp2[i - 2], dp2[i - 1]); 

        return Math.Max(dp1[dp1.Length - 2], dp2[dp2.Length - 1]);
    }
}
