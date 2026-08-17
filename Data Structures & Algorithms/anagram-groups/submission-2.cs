public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var groups = new List<List<string>>();
        var dict = new Dictionary<string, List<string>>();

        foreach (string word in strs)
        {
            var counting = new int[26];
            foreach (char ch in word)
                counting[ch - 'a']++;

            string key = string.Join(',', counting);

            if (!dict.ContainsKey(key)) 
                dict[key] = new List<string>();

            dict[key].Add(word);
        }

        foreach (var pair in dict)
            groups.Add(pair.Value);

        return groups;
    }
}
