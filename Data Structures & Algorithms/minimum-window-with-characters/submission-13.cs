public class Solution {
    public string MinWindow(string s, string t) {
        if (t.Length > s.Length) return string.Empty;
        var dictS = new Dictionary<char, int>();
        var dictT = new Dictionary<char, int>();    
    
        for (int i = 0; i < t.Length; i++)
        {
            if (dictT.ContainsKey(t[i])) dictT[t[i]]++;
            else dictT[t[i]] = 1;
        }

        int l = 0, r = 0, min = int.MaxValue;
        string result = string.Empty;

        while (l < s.Length)
        {       
            if (!Validate(dictS, dictT)) 
            {
                if (r >= s.Length) break;

                if (dictS.ContainsKey(s[r])) dictS[s[r++]]++;
                else dictS[s[r++]] = 1;
            }
            else
            {
                if (r - l < min)
                {
                    min = r - l;
                    result = s.Substring(l, r - l);
                }

                dictS[s[l]]--;
                l++;
            }
        }

        return result;
    }

    private bool Validate(Dictionary<char, int> dict1, Dictionary<char, int> dict2)
    {
        foreach (var item in dict2)
        {
            if (!dict1.ContainsKey(item.Key)) return false;
            if (dict1[item.Key] < item.Value) return false;
        }

        return true;
    }
}