public class Solution {
    public int[][] Merge(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        var list = new List<List<int>>();

        int prevstart = intervals[0][0];
        int prevend = intervals[0][1];
        for (int i = 1; i < intervals.Length; i++)
        {   
            if (intervals[i][0] > prevend)
            {
                list.Add(new List<int>());
                list[list.Count - 1].Add(prevstart);
                list[list.Count - 1].Add(prevend);

                prevstart = intervals[i][0];
                prevend = intervals[i][1];  
            }
            else prevend = Math.Max(intervals[i][1], prevend);
        }   

        list.Add(new List<int>());
        list[list.Count - 1].Add(prevstart);
        list[list.Count - 1].Add(prevend); 

        var result = new int[list.Count][];
        for (int i = 0; i < list.Count; i++)
        {
            result[i] = new int[2];

            result[i][0] = list[i][0];
            result[i][1] = list[i][1];
        }

        return result; 
    }
}
