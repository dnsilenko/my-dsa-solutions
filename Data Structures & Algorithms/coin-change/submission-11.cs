public class Solution
{
    private Dictionary<int, int> memo = new Dictionary<int, int>();

    public int CoinChange(int[] coins, int amount)
    {
        int minCoins = Dfs(amount, coins);
        return minCoins == int.MaxValue ? -1 : minCoins;
    }

    private int Dfs(int amount, int[] coins) // мінімальна кількість монет, що складають amount
    {
        if (amount == 0) return 0; 
        if (memo.ContainsKey(amount)) return memo[amount]; // якщо вже обчислювали такий результат

        int res = int.MaxValue;
        foreach (int coin in coins) // перебираємо кожну монету
        {
            if (amount >= coin) // монета підходить, якщо не перевищує суму
            {
                int result = Dfs(amount - coin, coins); 
                if (result != int.MaxValue) res = Math.Min(res, 1 + result);
            }
        }

        memo[amount] = res;
        return res;
    }
}
