public class Solution
{
    public bool IsPalindrome(string s)
    {
        var sb = new StringBuilder();
        foreach (char ch in s)
        {
            if (char.IsLetterOrDigit(ch)) sb.Append(ch);
        }                     

        string word = sb.ToString().ToLower();
        for (int i = 0, j = word.Length - 1; i < j; i++, j--)
            if (word[i] != word[j]) return false;

        return true;                 
    }
}
