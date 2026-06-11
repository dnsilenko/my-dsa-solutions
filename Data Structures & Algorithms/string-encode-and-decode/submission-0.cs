public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();
        foreach (var item in strs)
        {
            sb.Append($"{item}\x1C");
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var splited = s.Split("\x1C");
        var list = new List<string>();

        for (int i = 0; i < splited.Length - 1; i++)
        {
            list.Add(splited[i]);
        }

        return list;
   }
}
