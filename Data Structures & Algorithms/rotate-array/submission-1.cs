public class Solution {
    public void Rotate(int[] nums, int k) {
        while (k >= nums.Length)
        {
            k -= nums.Length;
        }

        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);    
    }

    private void Reverse(int[] nums, int s, int e)
    {
        while (s < e)
        {
            (nums[s], nums[e]) = (nums[e], nums[s]);
            s++;
            e--;
        }
    }
}