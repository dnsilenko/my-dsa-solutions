public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));
        var output = new List<int[]>();
        output.Add(intervals[0]); // додаємо перший інтервал

        foreach (var interval in intervals) // перебираємо інтервали 
        {
            int lastEnd = output[output.Count - 1][1]; // кінець останнього інтервалу

            if (interval[0] <= lastEnd)
            {   // оновлюємо кінець останнього інтервалу: 
                // обираємо більше значення серед кінців останнього доданого та поточного
                output[output.Count - 1][1] = Math.Max(lastEnd, interval[1]);
            }
            else
            {
                output.Add(new int[] { interval[0], interval[1] } );
            }
        }

        return output.ToArray();
    }
}
