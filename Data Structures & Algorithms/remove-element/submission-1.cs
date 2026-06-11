public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int counter = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                nums[i] = -1;
                counter++;
            }
        }       

        Comparison<int> comparison = (a, b) => b.CompareTo(a);
        Array.Sort(nums, comparison);

        return nums.Length - counter;
    }
}