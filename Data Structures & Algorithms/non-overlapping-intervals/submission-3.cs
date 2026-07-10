public class Solution {
    public int EraseOverlapIntervals(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        int counter = 0;
        int prevend = intervals[0][1];
        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] < prevend) 
            {
                counter++;
                prevend = Math.Min(intervals[i][1], prevend);
            }
            else prevend = intervals[i][1];
        }          
        
        return counter;
    }
}
