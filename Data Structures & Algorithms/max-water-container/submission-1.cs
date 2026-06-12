public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0, r = heights.Length - 1, max = 0;
        while (l < r)
        {
            int area = (r - l) * Math.Min(heights[l], heights[r]);
            if (max < area) max = area;

            if (heights[l] < heights[r]) l++;
            else r--;
        }

        return max;
    }
}
