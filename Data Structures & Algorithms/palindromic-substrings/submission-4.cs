public class Solution {
    public int CountSubstrings(string s)
    {
        int counter = s.Length;
        for (int i = 0; i < s.Length; i++) 
        {
            var sb1 = new StringBuilder();

            //case1:
            for (int l = i - 1, r = i; l >= 0 && r < s.Length; l--, r++)
            {
                sb1.Insert(0, s[l]);
                sb1.Append(s[r]);
                if (IsPalindrome(sb1.ToString())) counter++;
            }

            var sb2 = new StringBuilder(); 
            sb2.Append(s[i]);

            // case2:
            for (int l = i - 1, r = i + 1; l >= 0 && r < s.Length; l--, r++)
            {
                if (s[l] == s[r]) counter++;
                else break;
            }
        }     

        return counter;    
    }

    private bool IsPalindrome(string word)
    {
        for (int i = 0, j = word.Length - 1; i < j; i++, j--)
            if (word[i] != word[j]) return false;

        return true;
    }
}
