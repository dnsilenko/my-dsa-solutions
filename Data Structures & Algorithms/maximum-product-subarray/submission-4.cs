public class Solution
{
    public int MaxProduct(int[] nums)
    {
        int result = nums[0];
        int min = 1, max = 1;

        foreach (int num in nums)
        {
            int temp = max * num; // зберігаємо значення до зміни максимального добутку

            max = Math.Max(Math.Max(num * max, num * min), num);
            min = Math.Min(Math.Min(temp, num * min), num);

            result = Math.Max(result, max);
        }

        return result;
    }
}