public class Solution {
    public bool IsPalindrome(string s) {
        int i = 0, j = s.Length - 1;
        while (i < j)
        {
            char ch1 = Char.ToLower(s[i]);
            char ch2 = Char.ToLower(s[j]);

            if (!IsNumber(ch1) && (ch1 < 'a' || ch1 > 'z')) 
            {
                i++;
                continue;
            }
            else if (!IsNumber(ch2) && (ch2 < 'a' || ch2 > 'z'))
            {
                j--;
                continue;
            }

            if (ch1 != ch2) return false;
            
            i++;
            j--;
        }    

        return true;
    }

    private bool IsNumber(char ch)
    {
        if (ch < '0' || ch > '9') return false;
        
        return true;
    }
}
