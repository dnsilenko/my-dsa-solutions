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
    public List<List<int>> LevelOrder(TreeNode root)
    {
        var result = new List<List<int>>();
        var queue = new Queue<TreeNode>();
        
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int count = queue.Count;
            var list = new List<int>();

            for (int i = 0; i < count; i++)
            {
                var node = queue.Dequeue();
                if (node is null) continue;

                list.Add(node.val);
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }

            if (list.Count > 0) result.Add(list);
        }

        return result;           
    }
}
