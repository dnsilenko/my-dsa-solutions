public class Solution {
    public string SimplifyPath(string path) {
        var split = path.Split("/");
        var stack = new Stack<string>();

        for (int i = 0; i < split.Length; i++)
        {
            if (split[i] == string.Empty) continue;

            if (OnlyDots(split[i]) == 1)
            {
                continue;
            }
            else if (OnlyDots(split[i]) == 2)
            {
                if (stack.Count > 0) stack.Pop();
                if (stack.Count > 0) stack.Pop();   
            }
            else
            {
                stack.Push("/");
                stack.Push(split[i]);
            }
        }    

        var stack2 = new Stack<string>();
        while (stack.Count > 0)
        {
            stack2.Push(stack.Pop());
        }

        string result = string.Empty;
        while (stack2.Count > 0)
        {
            result += stack2.Pop();
        }

        return result == string.Empty ? "/" : result;
    }

    private int OnlyDots(string word)
    {
        int counter = 0;
        foreach (var ch in word)
        {
            if (ch != '.') return 0;
            counter++;
        }

        return counter;
    }
}