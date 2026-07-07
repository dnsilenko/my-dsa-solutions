/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
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
        var dict = new Dictionary<Node, Node>();
        var queue = new Queue<Node>();

        dict[node] = new Node(node.val);
        queue.Enqueue(node);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            foreach (var neigh in current.neighbors)
            {
                if (!dict.ContainsKey(neigh))
                {
                    dict[neigh] = new Node(neigh.val);
                    queue.Enqueue(neigh);
                }

                dict[current].neighbors.Add(dict[neigh]);
            }
        }

        return dict[node];
    }
}































