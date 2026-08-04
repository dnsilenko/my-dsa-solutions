public class Solution
{
    public int MaxProduct(int[] nums)
    {
        int result = nums[0]; // базовий випадок
        int max = 1, min = 1; // множення на одиницю не впливає на результат

        foreach (int num in nums) // Kadane's algorithm                
        {
            int temp = num * max; // тимчасовий результат

            // знаходимо max i min
            max = Math.Max(Math.Max(num * max, num * min), num);
            min = Math.Min(Math.Min(temp, num * min), num);

            result = Math.Max(result, max);
        }
        
        return result;

    }
}
