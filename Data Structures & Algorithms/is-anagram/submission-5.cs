public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        var a1 = new int[26];
        var a2 = new int[26];    

        foreach (char ch in s) a1[ch - 'a']++;
        foreach (char ch in t) a2[ch - 'a']++;

        for (int i = 0; i < a1.Length; i++)
            if (a1[i] != a2[i]) return false;

        return true;
    }
}
