public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));
        var output = new List<int[]>();
        output.Add(intervals[0]);

        foreach (var interval in intervals)
        {
            int start = interval[0];
            int end = interval[1];
            int lastEnd = output[output.Count - 1][1];

            if (start <= lastEnd)
            {
                output[output.Count - 1][1] = Math.Max(lastEnd, end);
            }
            else
            {
                output.Add(new int[] { start, end } );
            }
        }

        return output.ToArray();
    }
}
