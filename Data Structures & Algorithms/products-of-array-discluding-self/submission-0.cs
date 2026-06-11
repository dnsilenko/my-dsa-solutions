public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var prefix = new int[nums.Length];
        var postfix = new int[nums.Length];

        prefix[0] = nums[0];
        postfix[nums.Length - 1] = nums[nums.Length - 1];

        for (int i = 1; i < nums.Length; i++)
        {
            prefix[i] = prefix[i - 1] * nums[i];
        }

        for (int i = nums.Length - 2; i >= 0; i--)
        {
            postfix[i] = postfix[i + 1] * nums[i];
        }   

        nums[0] = postfix[1];
        nums[nums.Length - 1] = prefix[nums.Length - 2];

        for (int i = 1; i < nums.Length - 1; i++)
        {
            nums[i] = prefix[i - 1] * postfix[i + 1];
        }

        return nums;
    }
}
