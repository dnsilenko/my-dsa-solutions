public class Solution {
    public int MaxSubArray(int[] nums)
    {
        int max = nums[0], current = 0;
        foreach (var num in nums)
        {
            current += num;
            if (current < 0)
            {
                max = nums[0];
            } 

            if (max < current)
            {
                max = current;
            }

            if (current < 0)
            {
                current = 0;
            }
        }    

        return max;
    }
}
