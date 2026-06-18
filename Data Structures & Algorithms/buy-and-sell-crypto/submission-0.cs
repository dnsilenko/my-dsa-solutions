public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0, min = prices[0];
        for (int i = 0; i < prices.Length; i++)
        {
            if (max < prices[i] - min) max = prices[i] - min;
            if (min > prices[i]) min = prices[i]; 
        }

        return max;
    }
}