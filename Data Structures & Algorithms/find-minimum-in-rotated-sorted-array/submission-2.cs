public class Solution
{
    public int FindMin(int[] nums)
    {
        int l = 0, r = nums.Length - 1;
        int result = nums[0];

        while (l <= r)
        {
            // якщо знаходимось у відсортованій частині
            if (nums[l] < nums[r]) return Math.Min(nums[l], result);

            int mid = (l + r) / 2;
            
            result = Math.Min(result, nums[mid]);

            if (nums[l] <= nums[mid]) l = mid + 1;
            else r = mid - 1;
        }

        return result;
    }
}