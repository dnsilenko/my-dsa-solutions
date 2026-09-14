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
    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        if (root is null && subRoot is null) return true;
        else if (root is null || subRoot is null) return false;     

        return Same(root, subRoot) || IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    private bool Same(TreeNode root, TreeNode subRoot)
    {
        if (root is null && subRoot is null) return true;
        else if (root is null || subRoot is null) return false;

        if (root.val != subRoot.val) return false;

        return Same(root.left, subRoot.left) && Same(root.right, subRoot.right);
    }
}
