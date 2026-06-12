public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0, r = nums.Length - 1, mid = (l + r) / 2;

        while (l <= r)
        {
            if (nums[mid] < target) l = mid + 1;
            else if (nums[mid] > target) r = mid - 1;
            else return mid;

            mid = (l + r) / 2;
        }

        return -1;    
    }
}
