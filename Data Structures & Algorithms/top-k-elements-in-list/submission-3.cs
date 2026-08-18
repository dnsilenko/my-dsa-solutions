public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();
        var list = new List<int>[nums.Length + 1];
        for (int i = 0; i < list.Length; i++)
            list[i] = new List<int>();

        foreach (int num in nums)
            if (dict.ContainsKey(num)) dict[num]++;
            else dict[num] = 1;

        foreach (var pair in dict)
            list[pair.Value].Add(pair.Key);

        int index = 0;
        var result = new int[k]; 
        for (int i = list.Length - 1; i >= 0 && index < k; i--)
        {
            foreach (var num in list[i])
                result[index++] = num;
        }

        return result;
    }
}