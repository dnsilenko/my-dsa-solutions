public class Solution
{
    public int MaxArea(int[] heights)
    {
        int l = 0, r = heights.Length - 1;
        int max = 0;

        while (l <= r)
        {
            int current = Math.Min(heights[l], heights[r]) * (r - l);
            if (current > max) max = current;

            if (heights[l] < heights[r]) l++;
            else r--;
        }

        return max;
    }
}
