public class Solution
{
    public int MaxProduct(int[] nums)
    {
        int result = nums[0], min = 1, max = 1;
        foreach (int num in nums)
        {
            int temp = max * num;

            max = Math.Max(Math.Max(num * min, num * max), num);
            min = Math.Min(Math.Min(num * min, temp), num);

            result = Math.Max(result, max);
        }            

        return result;
    }
}
