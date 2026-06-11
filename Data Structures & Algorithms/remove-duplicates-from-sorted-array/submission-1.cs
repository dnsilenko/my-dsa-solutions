public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                k++;
            }
        }

        int c = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[c++] = nums[i];
            }
        }

        return k;
    }
}