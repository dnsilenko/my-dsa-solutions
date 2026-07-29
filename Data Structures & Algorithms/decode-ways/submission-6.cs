public class Solution {
    public int NumDecodings(string s)
    {
        // dp[i] -> кількість способів декодувати префікс рядка
        var dp = new int[s.Length + 1]; 

        dp[0] = 1; // базовий випадок (префікса немає -> нічого не декодуємо)

        for (int i = 1; i < dp.Length; i++)        
        {   // s[i - 1] -> останній символ декодується як окрема літера
            if (s[i - 1] != '0') dp[i] = dp[i - 1];

            if (i - 2 < 0) continue; // щоб не вийти за межі

            if (s[i - 2] == '1' || (s[i - 2] == '2' && s[i - 1] < '7'))
                dp[i] += dp[i - 2];
        }

        return dp[dp.Length - 1];
    }
}