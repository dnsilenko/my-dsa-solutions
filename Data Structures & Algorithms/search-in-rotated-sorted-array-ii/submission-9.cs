public class Solution {
    public bool Search(int[] nums, int target) {
        
        int l = 0, r = nums.Length - 1, mid = (l + r) / 2;

        while (l <= r)
        {
            if (target == nums[mid]) return true;

            if (nums[l] < nums[mid])
            {
                if (target < nums[mid] && target >= nums[l]) r = mid - 1;
                else l = mid + 1;
            }
            else if (nums[l] > nums[mid]) 
            {
                if (target > nums[mid] && target <= nums[r]) l = mid + 1;
                else r = mid - 1;
            }
            else
            {
                l++;
            }

            mid = (l + r) / 2;
        }   

        return false;
    }
}