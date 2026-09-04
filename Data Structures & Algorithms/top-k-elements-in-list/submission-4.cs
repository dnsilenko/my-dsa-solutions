public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dict1 = new Dictionary<int, int>();
        var dict2 = new Dictionary<int, List<int>>();

        foreach (int value in nums) 
        {
            if (dict1.ContainsKey(value)) dict1[value]++;
            else dict1[value] = 1;
        }

        foreach (var item in dict1)
        {
            if (!dict2.ContainsKey(item.Value)) dict2[item.Value] = new List<int>();

            dict2[item.Value].Add(item.Key);
        }

        var result = new int[k];
        for (int i = nums.Length, j = 0; j < k; i--)
        {
            if (!dict2.ContainsKey(i)) continue;

            foreach (int num in dict2[i])
            {
                result[j++] = num;
            }
        }

        return result;
    }
}
