public class Solution
{
    public int[] CountBits(int n)
    {
        var dp = new int[n + 1];
        for (int i = 1; i <= n; i++) 
        {   
            dp[i] = dp[i / 2] + (i % 2 == 0 ? 0 : 1);
        }
        
        return dp;          
    }
}
