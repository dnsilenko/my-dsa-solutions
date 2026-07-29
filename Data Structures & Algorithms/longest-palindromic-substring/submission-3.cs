public class Solution {
    public string LongestPalindrome(string s)
    {
        string result = string.Empty;
        for (int i = 0; i < s.Length; i++)
        {
            var sb = new StringBuilder();
            for (int j = i; j < s.Length; j++)
            {
                sb.Append(s[j]);
                if (IsPalindrome(sb.ToString()) &&
                    sb.ToString().Length > result.Length) result = sb.ToString();
            }
        }    

        return result;
    }

    private bool IsPalindrome(string word)
    {
        for (int i = 0, j = word.Length - 1; i < j; i++, j--)
        {
            if (word[i] != word[j]) return false;
        }
        
        return true;
    }
}
