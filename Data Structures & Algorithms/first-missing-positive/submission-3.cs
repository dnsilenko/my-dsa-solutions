public class Solution {
    public int FirstMissingPositive(int[] nums) {

        for (int i = 0; i < nums.Length; i++) 
        {   // переставляємо числа на правильну позицію
            while (nums[i] >= 1 && // підходять додатні числа
                   nums[i] <= nums.Length && // підходять числа [1; n]
                   nums[nums[i] - 1] != nums[i]) // якщо на 0 індексі не одиниця (умовно)
            {
                int index = nums[i] - 1; // індекс: куди вставити поточне число 
                
                // вставляємо число під правильний індекс -> [1, 2, 3..]
                (nums[i], nums[index]) = (nums[index], nums[i]); 
            }
        }  

        for (int i = 0; i < nums.Length; i++)
        {   // якщо під поточним індексом не правильне значення
            if (nums[i] != i + 1) return i + 1; 
        }

        return nums.Length + 1; // наступне більше
        
    }
}