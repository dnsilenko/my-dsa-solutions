public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        if (intervals.Length == 0) return new int[][] { newInterval };

        var list = new List<int[]>();
        bool add = false;

        foreach (var interval in intervals) 
        { 
            if (!add && newInterval[0] <= interval[0])
            {
                list.Add(new int[] { newInterval[0], newInterval[1] } );
                add = true;
            }

            list.Add(new int[] { interval[0], interval[1] } );

            if (!add && interval[1] >= newInterval[0])
            {
                list.Add(new int[] { newInterval[0], newInterval[1] } );
                add = true;
            }
        }

        if (!add) list.Add(new int[] { newInterval[0], newInterval[1] } );

        var newlist = new List<int[]>();
        newlist.Add(list[0]);
        int lastend = 0;

        foreach (var interval in list)
        {
            lastend = newlist[newlist.Count - 1][1];  

            if (lastend >= interval[0])
            {
                newlist[newlist.Count - 1][1] = Math.Max(lastend, interval[1]); 
            }
            else
            {
                newlist.Add(new int[] { interval[0], interval[1] } );  
            }
        }

        return newlist.ToArray();
    }   
}
