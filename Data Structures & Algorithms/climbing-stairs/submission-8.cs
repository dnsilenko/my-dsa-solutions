public class Solution
{
    public int[] memo = null;
    public int ClimbStairs(int n)
    {     
        memo = new int[n];
        return DFS(n, 0);
    }

    private int DFS(int n, int i)
    {
        if (i >= n) return i == n ? 1 : 0;
        if (memo[i] != 0) return memo[i];

        memo[i] = DFS(n, i + 1) + DFS(n, i + 2); 
        return memo[i];   
    }
}
