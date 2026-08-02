public class Solution
{
    // key -> сума, для якої обчислюється мінімальна кількість монет
    // value -> мінімальна кількість монет, якщо неможливо -> int.MaxValue
    private Dictionary<int, int> memoization = new Dictionary<int, int>();
    public int CoinChange(int[] coins, int amount)
    {
        memoization[0] = 0; // base case
        int result = DFS(amount, coins);
        return result == int.MaxValue ? -1 : result;
    }

    private int DFS(int amount, int[] coins)
    {   // якщо вже було обчислено
        if (memoization.ContainsKey(amount)) return memoization[amount];        

        int result = int.MaxValue;
        foreach (int coin in coins)   
            if (amount - coin >= 0) 
            {
                int res = DFS(amount - coin, coins);
                if (res != int.MaxValue) result = Math.Min(result, 1 + res);
            }

        memoization[amount] = result;
        return result;
    }

}
