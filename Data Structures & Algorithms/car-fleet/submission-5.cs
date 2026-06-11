public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        var pairs = new (decimal pos, decimal speed)[n];
        for (int i = 0; i < n; i++) 
        {
            pairs[i] = ((decimal)position[i], (decimal)speed[i]);
        }

        Array.Sort(pairs, (a, b) => b.pos.CompareTo(a.pos));  
        var stack = new Stack<decimal>(); 
        stack.Push((target - pairs[0].pos) / pairs[0].speed);

        for (int i = 0; i < n; i++)
        {
            decimal time = (target - pairs[i].pos) / pairs[i].speed;
            if (stack.Peek() < time)
            {
                stack.Push(time);   
            }
        } 

        return stack.Count;
    }
}
