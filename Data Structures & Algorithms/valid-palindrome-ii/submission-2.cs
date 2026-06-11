public class Solution {
    public bool ValidPalindrome(string s) {
        int counter = 0;
        for (int i = 0, j = s.Length - 1; i < j; i++, j--)
        {
            if (s[i] != s[j])
            {
                if (IsPalindrome(s, i + 1, j))
                {
                    i++;
                    counter++;
                }
                else if (IsPalindrome(s, i, j - 1))
                {
                    j--;
                    counter++;
                }
                else
                {
                    counter += 2;
                }
            }        

            if (counter > 1)
            {
                return false;
            }      
        }       

        return true;
    }

    private bool IsPalindrome(string s, int start, int end)
    {
        while (start < end)
        {
            if (s[start] != s[end])
            {
                return false;
            }

            start++;
            end--;
        }

        return true;
    }
}