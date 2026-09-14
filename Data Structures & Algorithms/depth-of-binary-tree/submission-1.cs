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
    public int MaxDepth(TreeNode root)
    {
        return Depth(root, 1);
    }

    private int Depth(TreeNode root, int depth)
    {
        if (root is null) return depth - 1;
        else return Math.Max(Depth(root.left, depth + 1), Depth(root.right, depth + 1));
    }
}
