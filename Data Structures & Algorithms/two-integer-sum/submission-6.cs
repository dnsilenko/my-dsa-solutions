public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            dict[nums[i]] = i;
        }       

        for (int i = 0; i < nums.Length; i++)
        {
            int element = target - nums[i];
            if (dict.ContainsKey(element) && dict[element] != i)
            {
                return new int[] { i, dict[element] };
            }
        }   

        return new int[0];
    }
}