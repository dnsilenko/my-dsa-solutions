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

public class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root is null) return null;

        if (Find(root.left, p) && Find(root.right, q)) return root;
        else if (Find(root.left, q) && Find(root.right, p)) return root;

        if (root.val == p.val && (Find(root.left, q) || Find(root.right, q))) return root;
        else if (root.val == q.val && (Find(root.left, p) || Find(root.right, p))) return root;

        return LowestCommonAncestor(root.left, p, q) ?? LowestCommonAncestor(root.right, p, q);
    }

    private bool Find(TreeNode root, TreeNode node)
    {
        if (root is null) return false;
        if (root.val == node.val) return true;

        return Find(root.left, node) || Find(root.right, node);
    }
}
