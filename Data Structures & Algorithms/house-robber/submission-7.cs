public class Solution
{
    public int[] memo;

    public int Rob(int[] nums)
    {
        memo = new int[nums.Length]; // запам'ятовування результату
        return DFS(nums, 0);
    }
        private int DFS(int[] nums, int i)
        {
            if (i >= nums.Length) return 0;
            if (memo[i] != 0) return memo[i]; // якщо вже грабували поточний дім

            // грабуємо поточний та дім через один (і, і + 2) 
            // або наступний дім, а поточний тоді скіпаємо (і + 1)
            memo[i] = Math.Max(nums[i] + DFS(nums, i + 2), DFS(nums, i + 1));
            return memo[i];
        }
}
