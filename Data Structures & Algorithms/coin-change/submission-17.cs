public class Solution
{
    public Dictionary<int, int> memo = new Dictionary<int, int>();
    public int CoinChange(int[] coins, int amount)
    {
        memo[0] = 0;
        int result = DFS(coins, amount);

        return result != int.MaxValue ? result : -1;
    }

    private int DFS(int[] coins, int amount) // к-сть монет, щоб зібрати amount
    {
        if (memo.ContainsKey(amount)) return memo[amount];

        int result = int.MaxValue;
        foreach (int coin in coins)
        {
            if (coin <= amount)
            {
                int count = DFS(coins, amount - coin);
                if (count != int.MaxValue) result = Math.Min(result, count + 1);
            }
        }

        memo[amount] = result;
        return result;
    } 
}
