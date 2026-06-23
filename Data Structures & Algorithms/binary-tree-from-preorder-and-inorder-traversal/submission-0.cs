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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        
        var dict = new Dictionary<int, int>();  
        for (int i = 0; i < inorder.Length; i++) dict[inorder[i]] = i;     

        int idxpre = 0;
        return DFS(0, preorder.Length - 1, ref idxpre);

        TreeNode DFS(int l, int r, ref int idxpre)
        {
            if (r - l + 1 <= 0) return null;
            else if (idxpre >= preorder.Length) return null;

            int value = preorder[idxpre++];
            var root = new TreeNode(value);      

            root.left = DFS(l, dict[value] - 1, ref idxpre);
            root.right = DFS(dict[value] + 1, r, ref idxpre);

            return root;
        }
    }
}
