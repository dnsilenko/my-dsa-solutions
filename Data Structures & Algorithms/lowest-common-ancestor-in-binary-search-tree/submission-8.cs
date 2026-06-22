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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        return DFS(root, p, q);      
    }

    private TreeNode DFS(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root is null) return null;

        if (root.val <= p.val && root.val >= q.val) return root;
        if (root.val >= p.val && root.val <= q.val) return root;

        if (root.val >= p.val && root.val >= q.val) return DFS(root.left, p, q);
        else return DFS(root.right, p, q);
    }
}