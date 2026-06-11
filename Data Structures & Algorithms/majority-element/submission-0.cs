public class Solution {
    public int MajorityElement(int[] nums) {
        int maj = nums[0];
        int counter = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (counter == 0)
            {
                maj = nums[i];
                counter++;
            }
            else if (maj == nums[i])
            {
                counter++;
            }
            else
            {
                counter--;
            }
        }  

        return maj;
    }
}