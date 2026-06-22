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
    public bool IsValidBST(TreeNode root) {
        return DFS(root, int.MinValue, int.MaxValue);   
    }

    private bool DFS(TreeNode root, int min, int max)
    {
        if (root is null) return true;
        if (root.val <= min || root.val >= max) return false;

        bool left = DFS(root.left, min, root.val);
        bool right = DFS(root.right, root.val, max);

        return left && right;
    }
}