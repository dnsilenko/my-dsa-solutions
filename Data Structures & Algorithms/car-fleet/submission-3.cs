public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        var pairs = new (int pos, int speed)[n];
        for (int i = 0; i < n; i++) 
        {
            pairs[i] = (position[i], speed[i]);
        }

        Array.Sort(pairs, (a, b) => b.pos.CompareTo(a.pos));  
        var stack = new Stack<decimal>(); // time
        for (int i = 0; i < n; i++)
        {
            decimal time = (decimal)(target - pairs[i].pos) / pairs[i].speed;
            if (stack.Count == 0)
            {
                stack.Push(time);
            }  
            else if (stack.Peek() < time)
            {
                stack.Push(time);   
            }
        } 

        return stack.Count;
    }
}
