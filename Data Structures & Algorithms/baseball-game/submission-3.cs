public class Solution {
    public int CalPoints(string[] operations) {
        var stack = new Stack<int>();
        for (int i = 0; i < operations.Length; i++) 
        {
            if (operations[i] == "+")
            {
                int num1 = stack.Pop();
                int num2 = stack.Pop();
                stack.Push(num2);
                stack.Push(num1);
                stack.Push(num1 + num2);
            }
            else if (operations[i] == "C")
            {
                stack.Pop();
            }
            else if (operations[i] == "D")
            {
                stack.Push(stack.Peek() * 2);
            }
            else
            {
                stack.Push(int.Parse(operations[i]));
            }
        }      

        int result = 0;
        while (stack.Count != 0)
        {
            result += stack.Pop();
        }

        return result;
    }
}