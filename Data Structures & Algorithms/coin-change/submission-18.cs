public class Solution
{
    Dictionary<int, int> memo = new Dictionary<int, int>();
    public int CoinChange(int[] coins, int amount)
    {
        memo[0] = 0;
        int min = DFS(coins, amount);

        return min != int.MaxValue ? min : -1;
    }

    private int DFS(int[] coins, int amount)
    {
        if (memo.ContainsKey(amount)) return memo[amount];

        int result = int.MaxValue;
        foreach (int coin in coins)
        {
            if (coin <= amount)
            {
                int min = DFS(coins, amount - coin);
                if (min != int.MaxValue) result = Math.Min(result, min + 1);
            }
        }

        memo[amount] = result;
        return result;
    }
}
