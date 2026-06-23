/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int MaxPathSum(TreeNode root) {
        int sum = int.MinValue; DFS(root);
        return sum;

        int DFS(TreeNode node)
        {
            if (node is null) return 0;

            int left = Math.Max(DFS(node.left), 0);
            int right = Math.Max(DFS(node.right), 0);

            int summary = 0;
            if (node.val + left > node.val + right) summary = node.val + left;
            else summary = node.val + right;   

            if (sum < node.val + left + right) sum = node.val + left + right;
            sum = Math.Max(sum, summary); 

            return summary;
        }
    }
}