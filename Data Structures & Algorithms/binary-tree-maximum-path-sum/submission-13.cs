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
    public int MaxPathSum(TreeNode root)
    {
        int result = root.val;
        DFS(root, ref result);

        return result;
    }

    private int DFS(TreeNode root, ref int result)
    {
        if (root is null) return 0;

        int left = Math.Max(DFS(root.left, ref result), 0);
        int right = Math.Max(DFS(root.right, ref result), 0);

        result = Math.Max(result, root.val + left + right);
        return root.val + Math.Max(left, right);
    }
}
