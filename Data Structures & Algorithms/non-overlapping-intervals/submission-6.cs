public class Solution
{
    public int EraseOverlapIntervals(int[][] intervals)
    {
        Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));

        int counter = 0;
        int prevend = intervals[0][1];

        for (int i = 1; i < intervals.Length; i++)     
        {
            if (intervals[i][0] < prevend) // якщо початок поточного менший (перекриття)
            {
                counter++; // стираємо перекриваючий
                prevend = Math.Min(prevend, intervals[i][1]);
            }
            else prevend = intervals[i][1];
        }
        
        return counter;
    }
}
