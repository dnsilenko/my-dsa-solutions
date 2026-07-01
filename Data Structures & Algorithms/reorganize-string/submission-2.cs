public class Solution {
    public string ReorganizeString(string s) {

        var dict = new Dictionary<char, int>();
        foreach (var ch in s)
        {
            if (!dict.ContainsKey(ch)) dict[ch] = 1;
            else dict[ch]++;
        }      

        var maxHeap = new PriorityQueue<(char, int), int>();
        foreach (var item in dict) maxHeap.Enqueue((item.Key, item.Value), -item.Value);
        
        var sb = new StringBuilder();
        while (maxHeap.Count > 0)
        {
            (char ch, int count) = maxHeap.Dequeue();
            char ch2 = 'a'; int count2 = 0;

            string text = sb.ToString();
            if (text.Length > 0 && text[text.Length - 1] == ch) 
            {
                if (maxHeap.Count == 0) return string.Empty; 
                (ch2, count2) = maxHeap.Dequeue();

                sb.Append(ch2); count2--;            
                if (count2 != 0) maxHeap.Enqueue((ch2, count2), -count2);   

                maxHeap.Enqueue((ch, count), -count);
            }
            else
            {
                sb.Append(ch); count--;            
                if (count != 0) maxHeap.Enqueue((ch, count), -count);
            }
        }

        return sb.ToString();
    }
}