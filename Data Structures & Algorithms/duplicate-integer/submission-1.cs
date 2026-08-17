public class Solution
{
    public bool hasDuplicate(int[] nums) 
    {   
        var hs = new HashSet<int>();
        foreach (int num in nums)
        {
            if (hs.Contains(num)) return true;
            else hs.Add(num);
        }                       

        return false;
    }
}