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
    public bool IsValidBST(TreeNode root)
    {
        int[] leftDiapason = { int.MinValue, root.val };
        int[] rightDiapason = { root.val, int.MaxValue };

        return Validate(root.left, leftDiapason) && Validate(root.right, rightDiapason);
    }   

    private bool Validate(TreeNode root, int[] diapason)
    {
        if (root is null) return true;

        if (diapason[0] >= root.val || diapason[1] <= root.val) return false;

        int[] leftDiapason = { diapason[0], root.val };
        int[] rightDiapason = { root.val, diapason[1] };

        return Validate(root.left, leftDiapason) && Validate(root.right, rightDiapason);
    }
}
