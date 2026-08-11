public class Solution
{
    public int MissingNumber(int[] nums)
    {
        var hs = new HashSet<int>(nums);
        for (int i = 0; i < nums.Length; i++)
            if (!hs.Contains(i)) return i;

        return nums.Length;     
    }
}
