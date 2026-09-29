public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int result = nums[0];
        int current = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            current += nums[i];

            if (current > result) result = current;
            if (current < 0) current = 0;
        }      

        return result;     
    }
}
