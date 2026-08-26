public class Solution
{
    public int FindMin(int[] nums)
    {
        int l = 0, r = nums.Length - 1, mid = (l + r) / 2;
        int result = nums[0];

        while (l <= r)
        {
            // якщо знаходимось у відсортованій частині
            if (nums[l] < nums[r]) return Math.Min(nums[l], result);
            
            result = Math.Min(result, nums[mid]);

            if (nums[l] <= nums[mid]) l = mid + 1;
            else r = mid - 1;

            mid = (l + r) / 2;
        }

        return result;
    }
}