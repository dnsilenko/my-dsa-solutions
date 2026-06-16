public class Solution {
    public bool Search(int[] nums, int target) {        
        int l = 0, r = nums.Length - 1, mid = (l + r) / 2;

        while (l <= r)
        {
            if (target == nums[mid]) return true; // якщо поточне значення -> target

            // [1, 1, 0, 1, 1] -> позбуваємось одиниць зліва

            if (nums[l] == nums[mid]) l++; 
            if (l >= nums.Length) break; // якщо вийшли за межі -> target'a не існує

            if (nums[l] <= nums[mid]) // знаходимось у лівій частині
            {   
                if (target < nums[mid] && target >= nums[l]) r = mid - 1; // діапазон
                else l = mid + 1;
            }
            else // якщо знаходимось у правій частині
            {   
                if (target > nums[mid] && target <= nums[r]) l = mid + 1; // діапазон  
                else r = mid - 1;
            }

            mid = (l + r) / 2;
        }   

        return false;
    }
}