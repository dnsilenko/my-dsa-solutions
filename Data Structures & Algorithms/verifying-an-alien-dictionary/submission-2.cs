public class Solution {
    public bool IsAlienSorted(string[] words, string order)
    {
        var dict = new Dictionary<char, int>();    
        for (int i = 0; i < order.Length; i++)
        {
            dict[order[i]] = i;
        }

        for (int i = 1; i < words.Length; i++)
        {
            if (!OwnCompare(words[i - 1], words[i])) return false;
        }

        return true;

        bool OwnCompare(string word1, string word2)
        {
            for (int i = 0; i < word1.Length; i++)
            {
                if (i >= word2.Length) return false;

                bool trueorder = true;
                bool change = false;

                if (dict[word2[i]] < dict[word1[i]]) trueorder = false;
                if (dict[word2[i]] - dict[word1[i]] != 0) change = true;

                if (!change) continue;
                if (!trueorder) return false;
                else return true;
            }

            return true;
        }
    }
}