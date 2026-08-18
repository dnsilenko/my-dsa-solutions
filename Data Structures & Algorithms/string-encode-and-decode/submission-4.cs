public class Solution {

    public string Encode(IList<string> strs)
    {
        if (strs.Count == 0) return null;
        return string.Join("/devider/", strs);          
    }

    public List<string> Decode(string encode)
    {
        if (encode is null) return new List<string>();

        var words = encode.Split("/devider/");
        var list = new List<string>();

        foreach (string word in words)
            list.Add(word);

        return list;
    }
}
