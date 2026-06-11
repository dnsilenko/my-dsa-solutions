public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            int[] array = new int[26];
            for (int j = 0; j < strs[i].Length; j++) array[strs[i][j] - 'a']++;

            var sb = new StringBuilder();
            for (int j = 0; j < array.Length; j++) sb.Append($"{array[j].ToString()},");   

            string key = sb.ToString();
            if (dict.ContainsKey(key))
            {
                var list = dict[key];
                list.Add(strs[i]);
            }
            else
            {
                var list = new List<string>();
                list.Add(strs[i]);
                dict[key] = list;
            }
        }   

        var result = new List<List<string>>();
        foreach (var item in dict)// dictionary
        {
            result.Add(item.Value);    
        }  

        return result;
    }
}
