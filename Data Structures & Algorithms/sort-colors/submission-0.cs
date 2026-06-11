public class Solution {
    public void SortColors(int[] nums) {
        int r = 0, w = 0, b = 0;
        foreach (var num in nums)
        {
            if (num == 0) r++;
            else if (num == 1) w++;
            else if (num == 2) b++;
        }    

        int c = 0;
        foreach (var item in nums)
        {
            if (r > 0) 
            {
                nums[c++] = 0;
                r--;
            }
            else if (w > 0)
            {
                nums[c++] = 1;
                w--;
            }
            else if (b > 0)
            {
                nums[c++] = 2;
                b--;
            }
        }   
    }
}