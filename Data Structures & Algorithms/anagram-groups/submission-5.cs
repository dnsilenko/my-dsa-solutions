public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var dict = new Dictionary<string, List<string>>();

        foreach (string word in strs)
        {
            var counting = new int[26];
            foreach (char ch in word) counting[ch - 'a']++;

            var sb = new StringBuilder();
            foreach (int count in counting) 
            {
                sb.Append(count);
                sb.Append("-");
            }

            if (!dict.ContainsKey(sb.ToString()))
                dict[sb.ToString()] = new List<string>();

            dict[sb.ToString()].Add(word);
        }

        return dict.Values.ToList();
    }
}
