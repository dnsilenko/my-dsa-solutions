public class Solution
{
    public int[] GetOrder(int[][] tasks)
    {
        int[] indices = new int[tasks.Length];
        for (int i = 0; i < tasks.Length; i++) indices[i] = i;

        Array.Sort(indices, (a, b) => 
            tasks[a][0] != tasks[b][0] ? tasks[a][0].CompareTo(tasks[b][0]) : a.CompareTo(b));

        var minHeap = new PriorityQueue<int, (int procTime, int index)>();
        int[] result = new int[tasks.Length];
        long time = 0; int resIndex = 0, idx = 0;

        while (minHeap.Count > 0 || idx< tasks.Length)
        {
            while (idx < tasks.Length && tasks[indices[idx]][0] <= time)
            {
                int index = indices[idx];
                minHeap.Enqueue(index, (tasks[index][1], index));
                idx++;
            }

            if (minHeap.Count == 0) time = tasks[indices[idx]][0];
            else
            {
                int nextIndex = minHeap.Dequeue();
                time += tasks[nextIndex][1];
                result[resIndex++] = nextIndex;
            }
        }

        return result;
    }
}