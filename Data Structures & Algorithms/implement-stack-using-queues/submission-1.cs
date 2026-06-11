public class MyStack {

    Queue<int> q;
    public MyStack() {
        q = new Queue<int>();  
    }
    
    public void Push(int x) {
        q.Enqueue(x);    
    }
    
    public int Pop() {
        Queue<int> queue = new Queue<int>();
        int num = 0;
        while (!Empty())
        {
            num = q.Dequeue(); 
            if (!Empty())
            {
                queue.Enqueue(num);
            }
        }    

        q = queue;
        return num;
    }
    
    public int Top() {
        Queue<int> queue = new Queue<int>();
        int num = 0;
        while (!Empty())
        {
            num = q.Dequeue(); 
            queue.Enqueue(num);
        }    

        q = queue;
        return num;   
    }
    
    public bool Empty() {
        return q.Count == 0;   
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */