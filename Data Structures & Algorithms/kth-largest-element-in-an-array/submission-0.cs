public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var maxheap = new PriorityQueue<int, int>();       
        for (int i = 0; i < nums.Length; i++)
        {
            maxheap.Enqueue(nums[i], nums[i]);
            if (maxheap.Count > k) maxheap.Dequeue();
        }    

        return maxheap.Peek();
    }
}
