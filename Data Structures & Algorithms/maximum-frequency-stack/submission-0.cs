public class FreqStack {

    private Stack<int> stack;
    private Dictionary<int, int> dict;
    public FreqStack() {
        stack = new Stack<int>();
        dict = new Dictionary<int, int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if (dict.ContainsKey(val))
        {
            dict[val]++;
        }
        else
        {
            dict[val] = 1;
        }
    }
    
    public int Pop() {
        int max = 0;
        foreach (var item in dict)
        {
            if (max < item.Value)
            {
                max = item.Value;
            }
        }          

        int number = 0, count = 0;
        var stack2 = new Stack<int>();
        while (stack.Count > 0)
        {
            int num = stack.Pop();
            if (dict[num] == max && count == 0) 
            {
                dict[num]--;
                number = num;
                count++;
            }     
            else
            {
                stack2.Push(num);
            }
        }

        stack.Clear();
        while (stack2.Count > 0)
        {
            stack.Push(stack2.Pop());
        }

        return number;
    }
}

/**
 * Your FreqStack object will be instantiated and called as such:
 * FreqStack obj = new FreqStack();
 * obj.Push(val);
 * int param_2 = obj.Pop();
 */