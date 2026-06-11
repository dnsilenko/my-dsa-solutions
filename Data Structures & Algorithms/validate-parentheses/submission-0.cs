public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        foreach (var sym in s)
        {
            if ((sym == ')' || sym == ']' || sym == '}') && stack.Count == 0)
            {
                return false;
            }

            if (sym == ')' && stack.Peek() != '(') 
            {
                return false;
            }
            else if (sym == ']' && stack.Peek() != '[') 
            {
                return false;
            }
            else if (sym == '}' && stack.Peek() != '{') 
            {
                return false;
            }

            if (sym == ')' || sym == ']' || sym == '}')
            {
                stack.Pop();
            }
            else 
            {
                stack.Push(sym);
            }
        }   

        if (stack.Count != 0) 
        {
            return false;
        }

        return true;
    }
}
