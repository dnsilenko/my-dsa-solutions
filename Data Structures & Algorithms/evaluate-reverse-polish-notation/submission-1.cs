public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        for (int i = 0; i < tokens.Length; i++)
        {
            string op = tokens[i];
            if (op == "+")
            {
                int num1 = stack.Pop();
                int num2 = stack.Pop();

                stack.Push(num2 + num1);
            }
            else if (op == "-")
            {
                int num1 = stack.Pop();
                int num2 = stack.Pop();

                stack.Push(num2 - num1);
            }
            else if (op == "*")
            {
                int num1 = stack.Pop();
                int num2 = stack.Pop();

                stack.Push(num2 * num1);
            }
            else if (op == "/")
            {
                int num1 = stack.Pop();
                int num2 = stack.Pop();

                stack.Push(num2 / num1);
            }
            else
            {
                stack.Push(int.Parse(tokens[i]));
            }
        }   

        return stack.Peek();   
    }
}
