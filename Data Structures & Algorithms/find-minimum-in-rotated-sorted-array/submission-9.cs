public class Solution
{
    public int FindMin(int[] nums)
    {
        int l = 0, r = nums.Length - 1, mid = (l + r) / 2;

        while (l < r)
        {
            if (nums[l] < nums[r])
            {
                r = mid - 1;
            }
            else if (nums[l] > nums[r])
            {
                if (nums[mid] > nums[r]) l = mid + 1;
                else r = mid;
            }

            mid = (l + r) / 2;
        }      

        return nums[l];
    }
}
