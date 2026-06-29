public class Solution {
    public int LastStoneWeight(int[] stones) {
        var maxheap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));  

        for (int i = 0; i < stones.Length; i++)
        {
            maxheap.Enqueue(stones[i], stones[i]);
        }     

        while (maxheap.Count > 1)
        {
            int x = maxheap.Dequeue();
            int y = maxheap.Dequeue();

            maxheap.Enqueue(Math.Abs(x - y), Math.Abs(x - y));
        }

        return maxheap.Dequeue();
    }
}