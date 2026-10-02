public class Solution
{
    public int Search(int[] nums, int target)
    {
        int l = 0, r = nums.Length - 1, mid = (l + r) / 2;

        while (l <= r)
        {
            if (target == nums[mid]) return mid;

            if (nums[l] <= nums[mid])
            {
                if (nums[l] > target || target > nums[mid]) l = mid + 1;
                else r = mid - 1;  
            }
            else
            {
                if (nums[mid] > target || target > nums[r]) r = mid - 1;
                else l = mid + 1;         
            }

            mid = (l + r) / 2;
        }

        return -1;   
    }
}
