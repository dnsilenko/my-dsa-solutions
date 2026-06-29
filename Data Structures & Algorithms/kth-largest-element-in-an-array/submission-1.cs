public class Solution {
    public int FindKthLargest(int[] nums, int k) {

        var minheap = new PriorityQueue<int, int>();       
        for (int i = 0; i < nums.Length; i++)
        {
            minheap.Enqueue(nums[i], nums[i]);
            if (minheap.Count > k) minheap.Dequeue();
        }    

        return minheap.Peek();
    }
}
