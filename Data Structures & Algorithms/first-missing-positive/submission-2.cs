public class Solution {
    public int FirstMissingPositive(int[] nums) {

        for (int i = 0; i < nums.Length; i++)
        {
            while (nums[i] >= 1 && nums[i] <= nums.Length && nums[nums[i] - 1] != nums[i])
            {
                int correct = nums[i] - 1;
                (nums[i], nums[correct]) = (nums[correct], nums[i]);
            }
        }  

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i + 1) return i + 1;
        }

        return nums.Length + 1;
    }
}