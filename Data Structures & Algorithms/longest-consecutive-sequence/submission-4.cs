public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        var hs = new HashSet<int>(nums);
        int max = 0;

        foreach (int num in nums)
        {
            if (hs.Contains(num - 1)) continue;

            int length = 0;
            for (int n = num; hs.Contains(n); n++) length++;

            max = Math.Max(max, length);
        }

        return max;
    }
}