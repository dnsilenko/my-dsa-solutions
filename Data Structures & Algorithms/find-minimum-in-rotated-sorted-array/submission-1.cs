public class Solution
{
    public int FindMin(int[] nums)
    {
        int l = 0, r = nums.Length - 1;
        int mid = (l + r) / 2;

        while (l < r)         
        {
            if (nums[mid] < nums[r]) r = mid;
            else l = mid + 1;

            mid = (l + r) / 2;
        }  

        return nums[l];
    }
}