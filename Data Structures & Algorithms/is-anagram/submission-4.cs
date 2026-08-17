public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        var counting1 = new int[26];
        var counting2 = new int[26];

        foreach (char ch in s)
        {
            counting1[ch - 'a']++;
        }

        foreach (char ch in t)
        {
            counting2[ch - 'a']++;
        }  

        for (int i = 0; i < 26; i++)
            if (counting1[i] != counting2[i]) return false;

        return true; 
    }
}
