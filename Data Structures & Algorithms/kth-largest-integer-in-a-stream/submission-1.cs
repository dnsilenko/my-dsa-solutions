public class KthLargest {

    private PriorityQueue<int, int> minHeap;
    private int kth;

    public KthLargest(int k, int[] nums) // ініціалізація об'єкту
    {   
        kth = k; 
        minHeap = new PriorityQueue<int, int>();    

        // першочергове заповнення купи
        foreach (var num in nums) _ = Add(num);
    }
    
    public int Add(int val) // додає елемент на повертає k-найбільший
    {
        minHeap.Enqueue(val, val);
        if (minHeap.Count > kth) minHeap.Dequeue();

        return minHeap.Peek();     
    }
}
