public class MedianFinder {

    public PriorityQueue<int, int> left;
    public PriorityQueue<int, int> right;

    public MedianFinder()
    {
        left = new PriorityQueue<int, int>(
            Comparer<int>.Create((a, b) => b.CompareTo(a)));

        right = new PriorityQueue<int, int>();
    }
    
    public void AddNum(int num)
    {
        if (left.Count > 0 && num > left.Peek()) right.Enqueue(num, num);
        else left.Enqueue(num, num);

        if (right.Count - left.Count > 1)
        {
            int val = right.Dequeue();
            left.Enqueue(val, val);
        }
        else if (left.Count - right.Count > 1)
        {
            int val = left.Dequeue();
            right.Enqueue(val, val);
        }
    }
    
    public double FindMedian()
    {
        if (left.Count > right.Count) return left.Peek();
        if (right.Count > left.Count) return right.Peek();

        return (double)(left.Peek() + right.Peek()) / 2;
    }
}
