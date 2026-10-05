public class Solution
{
    public int[] memo; 
    
    public int ClimbStairs(int n)
    {     
        memo = new int[n]; // запам'ятовуватимемо проміжні результати
        return DFS(n, 0);
    }
        private int DFS(int n, int i)
        {
            // повертаємо 1, якщо знаходимось на останній сходинці
            if (i >= n) return i == n ? 1 : 0; 
            if (memo[i] != 0) return memo[i];

            // к-сть різних способів дістатись до конкретної сходинки:
            // це к-сть способів, зробивши 1/2 кроки
            memo[i] = DFS(n, i + 1) + DFS(n, i + 2);  
            return memo[i];   
        }
}
