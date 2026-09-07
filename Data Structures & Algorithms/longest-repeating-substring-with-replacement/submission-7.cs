public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int l = 0, result = 0, maxFreq = 0;
        var count = new Dictionary<char, int>(); // кількість кожного символу
        
        for (int r = 0; r < s.Length; r++)
        {
            if (count.ContainsKey(s[r])) count[s[r]]++;
            else count[s[r]] = 1;

            // максимальна частота конкретного символа
            maxFreq = Math.Max(maxFreq, count[s[r]]);

            // вида
            while (r - l + 1 - maxFreq > k) count[s[l++]]--;

            result = Math.Max(result, r - l + 1);
        }

        return result;
    }
}