public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int profit = 0;
        int minPrice = prices[0];
        
        for (int i = 1; i < prices.Length; i++)
        {
            if (profit < prices[i] - minPrice) profit = prices[i] - minPrice;
            if (minPrice > prices[i]) minPrice = prices[i];
        }  

        return profit;
    }
}