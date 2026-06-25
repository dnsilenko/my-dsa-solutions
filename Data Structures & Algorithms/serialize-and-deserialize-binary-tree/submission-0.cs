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
    public string Serialize(TreeNode root)
    {
        if (root is null) return string.Empty;

        var sb = new StringBuilder();
        DFS(root, sb);

        sb.Remove(sb.Length - 1, 1);

        return sb.ToString();
    }

    public TreeNode Deserialize(string data)
    {
        if (string.IsNullOrWhiteSpace(data)) return null;

        var seq = data.Split(','); 
        
        int idx = 0;
        return CreateTree(new TreeNode(), seq, ref idx);  
    }

    private TreeNode CreateTree(TreeNode root, string[] seq, ref int idx)
    {
        if (idx >= seq.Length || seq[idx] == "N") 
        {
            idx++;
            return null;
        }

        root.val = int.Parse(seq[idx++]);
        root.left = CreateTree(new TreeNode(), seq, ref idx);
        root.right = CreateTree(new TreeNode(), seq, ref idx);

        return root;
    }

    private string DFS(TreeNode root, StringBuilder sb)
    {
        if (root is null) return "N,";

        sb.Append(root.val + ",");
        sb.Append(DFS(root.left, sb));
        sb.Append(DFS(root.right, sb));

        return string.Empty;
    }
}
