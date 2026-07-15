public class Solution {
    public bool CanJump(int[] nums)
    {
        int max = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > max) return false;
            max = Math.Max(i + nums[i], max);
        }   

        return true;   
    }
}
