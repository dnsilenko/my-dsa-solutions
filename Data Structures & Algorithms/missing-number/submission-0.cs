public class Solution
{
    public int MissingNumber(int[] nums)
    {
        var hs = new HashSet<int>();
        foreach (var num in nums)
            hs.Add(num);

        for (int i = 0; i <= nums.Length; i++)
            if (!hs.Contains(i)) return i;

        return 0;     
    }
}
