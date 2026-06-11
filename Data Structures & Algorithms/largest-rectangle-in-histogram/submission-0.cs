public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var stack = new Stack<int>();
        int max = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            while (stack.Count > 0 && heights[i] < heights[stack.Peek()])
            {
                int left = stack.Pop();
                int index = -1;
                if (stack.Count != 0)
                {
                    index = stack.Peek();
                }

                int square = (i - index - 1) * heights[left]; 
                if (max < square)
                {
                    max = square;
                }
            }
            
            if (stack.Count == 0 || heights[i] >= heights[stack.Peek()])
            {
                stack.Push(i);
            }
        }    

        while (stack.Count > 0)
        {
            int left = stack.Pop();
            int index = -1;
            if (stack.Count != 0)
            {
                index = stack.Peek();
            }

            int square = (heights.Length - index - 1) * heights[left]; 
            if (max < square)
            {
                max = square;
            }
        } 

        return max;     
    }
}