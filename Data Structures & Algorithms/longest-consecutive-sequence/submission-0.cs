public class Solution {
    public int LongestConsecutive(int[] nums) {
        var hs = new HashSet<int>();
        foreach (var num in nums)
        {
            if (!hs.Contains(num))
            {
                hs.Add(num);
            }
        }    

        int max = 0;
        foreach (var num in nums)
        {
            if (hs.Contains(num - 1))
            {
                continue;
            }

            int current = 0;
            int number = num;
            while (hs.Contains(number))
            {
                number++;
                current++;
            }   

            if (max < current)
            {
                max = current;
            }
        }    

        return max;
    }
}