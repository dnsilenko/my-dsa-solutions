public class Solution {
    public int SplitArray(int[] nums, int k) {
        
        int l = 0, r = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            l = Math.Max(l , nums[i]);
            r += nums[i];
        }

        int result = r, mid = (l + r) / 2;
        while (l <= r)
        {
            if (CanSplit(nums, k, mid))
            {
                result = mid;
                r = mid - 1;
            }
            else
            {
                l = mid + 1;
            }

            mid = (l + r) / 2;
        }
        
        return result; 
    }

    private bool CanSplit(int[] nums, int k, int sum)
    {
        int subarray = 1, currentSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            currentSum += nums[i];
            if (currentSum > sum)
            {
                subarray++;
                currentSum = nums[i];
            }

            if (subarray > k) return false;
        }

        return true;
    }
}