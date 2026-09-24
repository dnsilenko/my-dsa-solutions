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

        var visited = new Dictionary<Node, Node>();
        var queue = new Queue<Node>();
        visited[node] = new Node(node.val);
        
        queue.Enqueue(node);
        while (queue.Count > 0)
        {
            int count = queue.Count;
            for (int i = 0; i < count; i++)
            {
                var or = queue.Dequeue();
                var neigh = new List<Node>();
            
                foreach (var n in or.neighbors)
                {
                    if (!visited.ContainsKey(n))
                    {
                        var copy = new Node(n.val);
                        neigh.Add(copy);

                        queue.Enqueue(n);
                        visited[n] = copy;
                    }
                    else neigh.Add(visited[n]);      
                } 

                visited[or].neighbors = neigh;
            }
        }   

        return visited[node];
    }
}
