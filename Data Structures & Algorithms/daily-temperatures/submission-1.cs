public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var stack = new Stack<int>();
        var result = new int[temperatures.Length];
        for (int i = temperatures.Length - 1; i >= 0; i--)
        {
            while (stack.Count != 0 && temperatures[stack.Peek()] <= temperatures[i])
            {
                stack.Pop();
            }

            result[i] = stack.Count == 0 ? 0 : stack.Peek() - i; 
            stack.Push(i);  
        }   

        return result;
    }
}