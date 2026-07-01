public class Solution
{
    public int[] GetOrder(int[][] tasks)
    {
        int[] indices = new int[tasks.Length];
        for (int i = 0; i < tasks.Length; i++) indices[i] = i;

        Array.Sort(indices, (a, b) => tasks[a][0].CompareTo(tasks[b][0]));

        var minHeap = new PriorityQueue<int, (int procTime, int idx)>();
        int[] result = new int[tasks.Length];
        int time = 0; int index = 0, j = 0;

        while (minHeap.Count > 0 || j < tasks.Length)
        {
            while (j < tasks.Length && tasks[indices[j]][0] <= time)
            {
                int idx = indices[j]; // індекс поточного завдання
                minHeap.Enqueue(idx, (tasks[idx][1], idx)); j++;
            }

            if (minHeap.Count == 0) time = tasks[indices[j]][0];
            else // якщо у minHeap є елемент на обробку:
            {
                int nextIndex = minHeap.Dequeue();
                time += tasks[nextIndex][1];
                result[index++] = nextIndex;
            }
        }

        return result;
    }
}