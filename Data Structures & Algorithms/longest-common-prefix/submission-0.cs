public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string result = string.Empty;
        int min = 200;
        foreach (var word in strs)
        {
            if (min > word.Length) 
            {
                min = word.Length;
            }
        }

        for (int i = 0; i < min; i++)
        {
            char target = strs[0][i];
            bool tg = true;
            for (int j = 0; j < strs.Length; j++)
            {
                if (strs[j][i] != target) tg = false;
            }

            if (tg)
            {
                result += target;
            }
            else
            {
                break;
            }
        }

        return result;
    }
}