public class Solution {
    public string DecodeString(string s) {
        var stackstring = new Stack<string>();
        var stacknumber = new Stack<string>();

        int i = 0;
        while (i < s.Length)
        {
            if (IsNum(s[i].ToString()))
            {
                stacknumber.Push(s[i].ToString());
            }
            else if (s[i] == '[')
            {
                stackstring.Push("[");
                stacknumber.Push("[");
            }
            else if (s[i] == ']')
            {
                if (stacknumber.Count > 0 && stacknumber.Peek() == "[") stacknumber.Pop();

                var builder = new StringBuilder();
                while (stackstring.Count > 0 && stackstring.Peek() != "[")
                {
                    builder.Insert(0, stackstring.Pop());
                }       

                string number = string.Empty;
                while (stacknumber.Count > 0 && stacknumber.Peek() != "[")
                {
                    number += stacknumber.Pop();
                }      

                string word = GetAll(number, builder.ToString());
                if (stackstring.Count > 0 && stackstring.Peek() == "[") stackstring.Pop();

                stackstring.Push(word);   
            }  
            else 
            {
                stackstring.Push(s[i].ToString());
            }

            i++;
        }

        var stack = new Stack<string>();
        while (stackstring.Count > 0)
        {
            stack.Push(stackstring.Pop());
        }

        string result = string.Empty;
        while (stack.Count > 0)
        {
            result += stack.Pop();
        }

        return result;
    }

    private string GetAll(string number, string word)
    {
        int count = GetNumber(number);
        var sb = new StringBuilder();
        for (int i = 0; i < count; i++)
        {
            sb.Append(word);
        }

        return sb.ToString();
    }

    private int GetNumber(string number)
    {
        string num = string.Empty;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            num += number[i];
        }

        return int.Parse(num);
    }

    private bool IsNum(string word)
    {
        foreach (var ch in word)
        {
            if (ch > '9') return false;
        }

        return true;
    }
}