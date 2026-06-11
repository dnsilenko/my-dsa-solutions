public class MyHashSet {

    private int[] array;
    public MyHashSet() {
        array = new int[1000001];  
    }
    
    public void Add(int key) {
        array[key] = 1;  
    }
    
    public void Remove(int key) {
        array[key] = 0; 
    }
    
    public bool Contains(int key) {
        return array[key] == 1; 
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */