public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        var maxheap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        var queue = new Queue<int[]>();
        var dict = new Dictionary<char, int>();

        foreach (var task in tasks)
        {
            if (!dict.ContainsKey(task)) dict[task] = 1;
            else dict[task]++;
        }

        foreach (var item in dict) maxheap.Enqueue(item.Value, item.Value);

        int time = 0;
        while (maxheap.Count > 0 || queue.Count > 0)
        {
            if (queue.Count > 0 && time >= queue.Peek()[1])
            {
                int[] array = queue.Dequeue();
                maxheap.Enqueue(array[0], array[0]);
            }

            if (maxheap.Count > 0)
            {
                int count = maxheap.Dequeue() - 1;
                if (count > 0) queue.Enqueue(new int[] {count, time + n + 1});
            }

            time++;
        }

        return time;
    }
}
