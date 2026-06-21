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
    public TreeNode InvertTree(TreeNode root) {
        return Invert(root);
    }

    private TreeNode Invert(TreeNode root)
    {
        if (root == null) return null;  

        var left = Invert(root.left);
        var right = Invert(root.right);

        root.left = right;
        root.right = left;

        return root;
    }
}