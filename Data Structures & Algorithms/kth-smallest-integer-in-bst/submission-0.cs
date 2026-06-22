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
    public int KthSmallest(TreeNode root, int k) {
        int counter = 0;
        return DFS(root, ref counter, k);
    }

    int DFS(TreeNode root, ref int counter, int k)
    {
        if (root is null) return -1;

        int left = DFS(root.left, ref counter, k);

        counter++;
        if (counter == k) return root.val;

        int right = DFS(root.right, ref counter, k); 

        return Math.Max(left, right);
    }
}