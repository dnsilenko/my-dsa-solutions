public class Solution
{
    public int ClimbStairs(int n)
    {     
        if (n == 1) return 1;
        var dp = new int[n];
        
        dp[0] = 1; // base case
        dp[1] = 2; // base case

        for (int i = 2; i < dp.Length; i++)
            dp[i] = dp[i - 1] + dp[i - 2]; // found correct formula

        return dp[dp.Length - 1]; // return last case                             
    }
}
