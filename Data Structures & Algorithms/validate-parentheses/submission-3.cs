public class Solution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        foreach (char ch in s)
        {
            if (ch == '(' || ch == '[' || ch == '{') stack.Push(ch);
            else 
            {
                if (stack.Count == 0) return false;

                char top = stack.Pop();
                if (ch == ')' && top != '(') return false;
                else if (ch == ']' && top != '[') return false;
                else if (ch == '}' && top != '{') return false;
            }
        }    

        return stack.Count == 0;
    }
}
