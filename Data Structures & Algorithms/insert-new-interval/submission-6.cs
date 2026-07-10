public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        if (intervals.Length == 0) 
        {
            var res = new int[1][]; res[0] = new int[2];
            res[0][0] = newInterval[0];
            res[0][1] = newInterval[1];

            return res;
        }

        var list = new List<List<int>>();
        bool add = false;
        for (int i = 0; i < intervals.Length; i++)
        {
            if (!add && newInterval[0] <= intervals[i][1])
            {
                list.Add(new List<int>());
                if (newInterval[1] <= intervals[i][1])
                {
                    list[list.Count - 1].Add(newInterval[0]);
                    list[list.Count - 1].Add(newInterval[1]);
                    i--; add = true;
                }
                else
                {
                    list[list.Count - 1].Add(Math.Min(intervals[i][0], newInterval[0]));
                    list[list.Count - 1].Add(Math.Max(intervals[i][1], newInterval[1]));
                }
            }
            else
            {
                list.Add(new List<int>());
                list[list.Count - 1].Add(intervals[i][0]);
                list[list.Count - 1].Add(intervals[i][1]);
            }
        }      

        if (!add)
        {
            list.Add(new List<int>());
            list[list.Count - 1].Add(newInterval[0]);
            list[list.Count - 1].Add(newInterval[1]); 
        }

        int prevend = list[0][1];
        for (int i = 1; i < list.Count; i++)
        {
            if (list[i][0] <= prevend)
            {
                list[i][0] = Math.Min(list[i][0], list[i - 1][0]);
                list[i][1] = Math.Max(list[i][1], list[i - 1][1]); 

                list.RemoveAt(i - 1);
                i--;
            }

            prevend = list[i][1];
        }     

        var result = new int[list.Count][];
        for (int i = 0; i < list.Count; i++)
        {
            result[i] = new int[2];
            result[i] = list[i].ToArray();
        }

        return result;
    }
}
