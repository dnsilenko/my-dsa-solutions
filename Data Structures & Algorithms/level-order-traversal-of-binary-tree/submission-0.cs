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
    public List<List<int>> LevelOrder(TreeNode root) {
        if (root is null) return new List<List<int>>();
        var list = new List<List<int>>();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var include = new List<int>();
            int count = queue.Count;
            while (count > 0)
            {
                count--;
                var node = queue.Dequeue();
                if (node is null) continue;

                if (node.left is not null) queue.Enqueue(node.left);
                if (node.right is not null) queue.Enqueue(node.right);

                include.Add(node.val);                
            }

            list.Add(include);
        }

        return list;
    }
}