/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public int MinMeetingRooms(List<Interval> intervals)
    {
        // використовуємо сортування за часом початку зусрічей, бо саме так
        // можна обробляти зустрічі у правильному хронологічному порядку
        intervals.Sort((a, b) => a.start.CompareTo(b.start));
        
        var minHeap = new PriorityQueue<int, int>();
        foreach (var interval in intervals)
        {   // якщо зустріч, що закінчиться найшвидше закінчилась перед початком 
            if (minHeap.Count > 0 && minHeap.Peek() <= interval.start)
            {
                minHeap.Dequeue();         
            }

            minHeap.Enqueue(interval.end, interval.end); // зберігаємо часи закінчення
        }  

        return minHeap.Count;
    }
}
