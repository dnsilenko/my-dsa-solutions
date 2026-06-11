public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var array = new int[nums.Length * 2];
        for (int i = 0, i2 = nums.Length; i < nums.Length; i++, i2++)
        {
            array[i] = nums[i];
            array[i2] = nums[i];
        }      

        return array;
    }
}