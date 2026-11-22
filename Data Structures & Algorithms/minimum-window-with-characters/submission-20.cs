public class Solution
{
    Dictionary<char, int> window = new();
    Dictionary<char, int> characters = new();
    
    int counter = 0;

    public string MinWindow(string s, string t) 
    {
        foreach (char ch in s) window[ch] = 0; // ініціалізація усіх ключів
        foreach (char ch in t) 
            if (!characters.ContainsKey(ch)) characters[ch] = 1;
            else characters[ch]++;

        int start = 0, length = int.MaxValue;

        for (int l = 0, r = 0; l < s.Length;)
        {
            if (r < s.Length && counter < characters.Keys.Count)
            {
                window[s[r]]++;
                if (characters.ContainsKey(s[r]) && window[s[r]] == characters[s[r]]) counter++;

                r++;
            }
            else
            {
                window[s[l]]--;
                if (characters.ContainsKey(s[l]) && window[s[l]] < characters[s[l]]) counter--;

                l++;
            }

            if (counter == characters.Keys.Count && r - l < length) 
            {
                length = r - l;
                start = l;
            }
        }   

        return length == int.MaxValue ? string.Empty : s.Substring(start, length);
    }
}












