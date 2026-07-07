public class Solution {
    public int FindJudge(int n, int[][] trust) {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < trust.Length; i++)
        {
            if (!dict.ContainsKey(trust[i][1])) dict[trust[i][1]] = 1;
            else dict[trust[i][1]]++;
        }   

        int judge = -1;
        foreach (var pair in dict) if (pair.Value == n - 1) judge = pair.Key;
        
        for (int i = 0; i < trust.Length; i++)
        {
            if (trust[i][0] == judge) return -1;
        }

        return judge; 
    }
}