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
    int index = 0; // current in the pre-order
    Dictionary<int, int> indices = new Dictionary<int, int>();

    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        for (int i = 0; i < inorder.Length; i++) indices[inorder[i]] = i;

        return DFS(preorder, 0, inorder.Length - 1);
    }

    private TreeNode DFS(int[] preorder, int l, int r)
    {
        if (l > r) return null;

        int value = preorder[index++];
        var root = new TreeNode(value);
        
        int mid = indices[value];
        root.left = DFS(preorder, l, mid - 1);
        root.right = DFS(preorder, mid + 1, r);
    
        return root;
    }
}









