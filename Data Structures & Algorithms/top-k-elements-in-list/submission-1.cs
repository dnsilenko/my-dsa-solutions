public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();     
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                dict[nums[i]]++;
            }
            else
            {
                dict.Add(nums[i], 1);
            }
        }

        var dictCounting = new Dictionary<int, List<int>>();
        foreach (var item in dict)
        {
            int number = item.Key;
            int count = item.Value;

            if (!dictCounting.ContainsKey(count))
            {
                var list = new List<int>();
                list.Add(number);

                dictCounting.Add(count, list);       
            }
            else
            {
                dictCounting[count].Add(number);
            }
        }

        var result = new int[k];
        for (int i = nums.Length, c = 0; i >= 0; i--)
        {
            if (!dictCounting.ContainsKey(i))
            {
                continue;
            }

            var list = dictCounting[i];
            for (int j = 0; j < list.Count; j++)
            {
                result[c++] = list[j];
            }

            if (c >= k)
            {
                break;
            }
        }

        return result;
    }
}