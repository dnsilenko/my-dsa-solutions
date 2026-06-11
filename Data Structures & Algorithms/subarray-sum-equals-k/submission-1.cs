public class Solution {
    public int SubarraySum(int[] nums, int k) {
        var dict = new Dictionary<int, int>();

        int counter = 0; dict[0] = 1; // базові випадки
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0) nums[i] += nums[i - 1]; // префіксна сума

            // нехай sum = nums[i], підмасивів існує стільки, скільки [nums[i] - k]
            if (dict.ContainsKey(nums[i] - k)) counter += dict[nums[i] - k];

            if (dict.ContainsKey(nums[i])) dict[nums[i]]++; // додаємо префіксну суму
            else dict[nums[i]] = 1;
        }         

        return counter;
    }
}