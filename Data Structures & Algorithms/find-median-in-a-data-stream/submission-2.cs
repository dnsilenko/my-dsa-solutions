public class MedianFinder {

    PriorityQueue<int, int> left;
    PriorityQueue<int, int> right;

    public MedianFinder() {
        left = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));    
        right = new PriorityQueue<int, int>(); // minHeap
    }
    
    public void AddNum(int num) {
        if (left.Count > 0 && num > left.Peek()) right.Enqueue(num, num);
        else left.Enqueue(num, num);

        if (left.Count - right.Count > 1)
        {
            int number = left.Dequeue();
            right.Enqueue(number, number);
        } 
        else if (right.Count - left.Count > 1)
        {
            int number = right.Dequeue();
            left.Enqueue(number, number);
        }
    }
    
    public double FindMedian() {
        if (left.Count > right.Count) return left.Peek();
        else if (right.Count > left.Count) return right.Peek();

        return (double)(left.Peek() + right.Peek()) / 2;     
    }
}
