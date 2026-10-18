public class Solution
{
    public int MaxProduct(int[] nums)
    {
        // через min/max, бо множення на від'ємне змінює місцями результати
        int result = nums[0], min = 1, max = 1;

        foreach (int num in nums) 
        {
            int temp = max * num; // зберігаємо результат (бо max далі оновлюватимемо)

            // фіксуємо min/max добутки серед підмасивів (або num: починаємо спочатку)
            max = Math.Max(Math.Max(num * max, num * min), num);
            min = Math.Min(Math.Min(temp, num * min), num);

            result = Math.Max(result, max); // найбільше значення добутків
        }

        return result; 
    }
}