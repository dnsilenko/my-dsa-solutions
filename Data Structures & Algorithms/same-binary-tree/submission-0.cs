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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        return IsSame(p, q);
    }

    private bool IsSame(TreeNode p, TreeNode q)
    {
        if (p is null && q is null) return true;
        else if (p is null || q is null) return false;

        if (p.val != q.val) return false;

        bool left = IsSame(p.left, q.left);
        bool right = IsSame(p.right, q.right);

        return left && right; 
    }
}
