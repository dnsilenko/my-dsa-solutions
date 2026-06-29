public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        
        var minheap = new PriorityQueue<int[], double>();
        for (int i = 0; i < points.Length; i++)
        {
            int x1 = points[i][0], y1 = points[i][1];
            double length = Math.Sqrt(x1 * x1 + y1 * y1); 

            minheap.Enqueue(new int[] {x1, y1}, length);
        }

        int[][] result = new int[k][];
        for (int i = 0; i < k; i++)
        {
            result[i] = new int[2];
            int[] array = minheap.Dequeue();
            
            result[i][0] = array[0];
            result[i][1] = array[1];
        }

        return result;
    }   
}
