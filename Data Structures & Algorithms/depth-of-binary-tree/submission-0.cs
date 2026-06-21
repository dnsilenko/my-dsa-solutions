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
    public int MaxDepth(TreeNode root) {
        return FindDepth(root, 0);
    }

    private int FindDepth(TreeNode root, int depth)
    {
        if (root == null) return depth;

        depth++;
        int left = FindDepth(root.right, depth);
        int right = FindDepth(root.left, depth);

        return Math.Max(left, right);
    }
}