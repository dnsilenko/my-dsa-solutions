/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution
{
    public int MinMeetingRooms(List<Interval> intervals)
    {
        var start = new int[intervals.Count];
        var end = new int[intervals.Count];

        for (int i = 0; i < intervals.Count; i++) start[i] = intervals[i].start;
        for (int i = 0; i < intervals.Count; i++) end[i] = intervals[i].end;

        Array.Sort(start);
        Array.Sort(end);

        int result = 0, counter = 0;
        for (int i = 0, e = 0; i < start.Length; i++)
        {
            if (start[i] < end[e]) counter++;
            else 
            {
                counter--;
                e++;
                i--;
            }

            if (result < counter) result = counter;
        }

        return result;
    }
}
