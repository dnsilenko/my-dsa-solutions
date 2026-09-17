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
    public int KthSmallest(TreeNode root, int k)
    {
        var list = new List<int>();
        DFS(root, list);

        for (int i = 1; i <= list.Count; i++) 
        {
            if (i == k) return list[i-1];
        }   

        return -1;
    }

    private void DFS(TreeNode root, List<int> list)
    {
        if (root is null) return;

        DFS(root.left, list);
        list.Add(root.val);
        DFS(root.right, list);
    }
}
















