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

public class Codec
{

    // Encodes a tree to a single string.
    public string Serialize(TreeNode root)
    {
        if (root is null) return null;

        string result = string.Empty;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int count = queue.Count;
            for (int i = 0; i < count; i++)
            {
                var node = queue.Dequeue();
                if (node is null) result += "n";
                else result += node.val.ToString();

                result += "/";

                if (node is null) continue;
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }
        }    

        return result;
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) 
    {
        if (data is null) return null;

        var list = data.Split('/').ToList<string>();
     
        int idx = 0;
        var root = new TreeNode(int.Parse(list[idx++]));
        
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int count = queue.Count;
            for (int i = 0; i < count; i++)
            {
                var node = queue.Dequeue();
                if (node is null) continue;
             
                var left = int.TryParse(list[idx], out _)
                    ? new TreeNode(int.Parse(list[idx])) : (TreeNode)null;
                idx++;

                var right = int.TryParse(list[idx], out _)
                    ? new TreeNode(int.Parse(list[idx])) : (TreeNode)null;
                
                idx++;

                node.left = left;
                node.right = right;

                queue.Enqueue(left);
                queue.Enqueue(right);
            }   
        }

        return root;
    }
}
