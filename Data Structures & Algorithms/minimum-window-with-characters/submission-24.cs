public class Solution
{
    Dictionary<char, int> window = new();
    Dictionary<char, int> characters = new();

    public string MinWindow(string s, string t) 
    {
        foreach (char ch in s) window[ch] = 0; // ініціалізація усіх ключів (string y dictionary)
        foreach (char ch in t) 
            if (!characters.ContainsKey(ch)) characters[ch] = 1;
            else characters[ch]++;

        int counter = 0; // скільки елементів мають щонайменше необхідну кількість
        (int start, int length) minimum = (0, int.MaxValue); // збереження границь накращого результату

        for (int l = 0, r = 0; l < s.Length;)
        {   
            if (r < s.Length && counter < characters.Keys.Count) // умова розширення вікна
            {
                window[s[r]]++;                     
                if (characters.ContainsKey(s[r]) && window[s[r]] == characters[s[r]]) counter++;

                r++;
            }
            else // умова звуження вікна
            {
                window[s[l]]--;
                if (characters.ContainsKey(s[l]) && window[s[l]] < characters[s[l]]) counter--;

                l++;
            }
            // збереження границь найкращого результату
            if (counter == characters.Keys.Count && r - l < minimum.length) minimum = (l, r - l);
        }   

        return minimum.length == int.MaxValue ? string.Empty : s.Substring(minimum.start, minimum.length);
    }
}












