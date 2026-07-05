public class Solution {  
    public List<string> GenerateParenthesis(int n)
    {
        var list = new List<string>();
        DFS(n, 1, 0, "(", list);

        return list;    
    }

    private void DFS(int n, int open, int close, string raw, List<string> list)
    {
        if (raw.Length == 2 * n) 
        {
            list.Add(raw);
            return;
        }

        if (close < open) DFS(n, open, close + 1, raw + ")", list);      

        if (open < n) DFS(n, open + 1, close, raw + "(", list); 
    }
}
