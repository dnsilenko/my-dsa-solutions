public class Solution {
    public int SubsetXORSum(int[] nums) {
        
        return DFS(0, 0);
        
        int DFS(int i, int sum)
        {
            if (i == nums.Length) return sum;

            return DFS(i + 1, sum ^ nums[i]) + DFS(i + 1, sum);
        }  
           
    }
}