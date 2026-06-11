public class MyQueue {

    Stack<int> stack;
    public MyQueue() {
        stack = new Stack<int>(); 
    }
    
    public void Push(int x) {
        stack.Push(x);
    }
    
    public int Pop() {
        if (Empty())
        {
            return -1;
        }       

        Stack<int> stack2 = new Stack<int>();
        int num = 0;
        while (!Empty())
        {
            num = stack.Pop();
            if (!Empty())
            {
                stack2.Push(num);
            }
        }

        while (stack2.Count != 0)
        {
            stack.Push(stack2.Pop());
        }

        return num;
    }
    
    public int Peek() {
        if (Empty())
        {
            return -1;
        }       

        Stack<int> stack2 = new Stack<int>();
        int num = 0;
        while (!Empty())
        {
            num = stack.Pop();
            stack2.Push(num);
        }

        while (stack2.Count != 0)
        {
            stack.Push(stack2.Pop());
        }

        return num;  
    }
    
    public bool Empty() {
        if (stack.Count == 0)
        {
            return true;
        } 

        return false;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */