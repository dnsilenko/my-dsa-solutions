public class Solution {
    public int LargestRectangleArea(int[] heights) {

        var stack = new Stack<int>(); int max = 0;
        for (int i = 0; i < heights.Length; i++)
        {   // поки поточна висота менша за попередню
            while (stack.Count > 0 && heights[i] < heights[stack.Peek()])
            {   // стовпець, за яким рахується площа (менші висоти нижче у stack)
                int current = stack.Pop(); 
                int left = stack.Count > 0 ? stack.Peek() : -1;
                int square = (i - left - 1) * heights[current]; 
                if (max < square) max = square;
            }
            // якщо стек порожній чи поточна висота більша за попередню
            stack.Push(i); 
        }    

        while (stack.Count > 0)
        {
            int current = stack.Pop();
            int left = stack.Count > 0 ? stack.Peek() : -1;
            int square = (heights.Length - left - 1) * heights[current]; 
            if (max < square) max = square;
        } 

        return max;     
    }
}