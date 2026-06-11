public class StockSpanner {
    List<int> list;
    int i;
    public StockSpanner() {
        list = new List<int>();  
        i = -1;
    }
    
    public int Next(int price) {
        list.Add(price);
        int counter = 1; i++;

        for (int j = i - 1; j >= 0; j--)
        {
            if (list[i] >= list[j])
            {
                counter++;
            }
            else
            {
                break;
            }
        }

        return counter;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */