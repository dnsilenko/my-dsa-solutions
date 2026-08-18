public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        var hs = new HashSet<int>();
        foreach (int num in nums)
            if (!hs.Contains(num)) hs.Add(num);

        int max = 0;
        foreach (int num in nums)
        {   
            int current = 0;

            if (!hs.Contains(num - 1))
                for (int i = num; hs.Contains(i); i++) current++;

            max = Math.Max(max, current);
        }          

        return max;         
    }
}