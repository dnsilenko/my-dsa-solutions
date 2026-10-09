public class Solution
{
    public int[] memo;
    public int ClimbStairs(int n)
    {     
        memo = new int[n];
        Array.Fill(memo, -1);

        return Go(n, 0);
    }       

    private int Go(int n, int i)
    {
        if (i > n) return 0;
        if (i == n) return 1;
        if (memo[i] != -1) return memo[i];

        memo[i] = Go(n, i + 1) + Go(n, i + 2);
        return memo[i];
    }
}
