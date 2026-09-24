/*
// Definition for a Node.
public class Node
{
    public int val;
    public IList<Node> neighbors;

    public Node()
    { 
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val)
    {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors)
    {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution
{
    public Node CloneGraph(Node node)
    {
        if (node is null) return null;

        var cloned = new Dictionary<Node, Node>();
        var q = new Queue<Node>();

        cloned[node] = new Node(node.val);
        q.Enqueue(node);

        while (q.Count > 0)
        {
            var original = q.Dequeue();
            foreach (var n in original.neighbors)
            {
                if (!cloned.ContainsKey(n))
                {
                    cloned[n] = new Node(n.val);
                    q.Enqueue(n);
                }

                cloned[original].neighbors.Add(cloned[n]);
            }
        }   

        return cloned[node];
    }
}
