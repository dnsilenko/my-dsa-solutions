public class Solution {
    public List<int> MajorityElement(int[] nums) {
        var dict = new Dictionary<int, int>();
        foreach (var item in nums)
        {
            if (dict.ContainsKey(item)) dict[item]++;
            else dict[item] = 1;
        }  

        int min = nums.Length / 3;
        var list = new List<int>();
        foreach (var item in dict)
        {
            if (item.Value > min) list.Add(item.Key);
        }

        return list;
    }
}