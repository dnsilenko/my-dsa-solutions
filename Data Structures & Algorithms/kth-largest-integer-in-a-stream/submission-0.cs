public class KthLargest {

    private PriorityQueue<int, int> minHeap;
    private int kth;

    public KthLargest(int k, int[] nums) {
        kth = k;
        minHeap = new PriorityQueue<int, int>();    

        foreach (var num in nums)
        {
            minHeap.Enqueue(num, num);
            if (minHeap.Count > kth) minHeap.Dequeue();
        }   
    }
    
    public int Add(int val)
    {
        minHeap.Enqueue(val, val);
        if (minHeap.Count > kth) minHeap.Dequeue();

        return minHeap.Peek();     
    }
}
