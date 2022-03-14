/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Preorder(Node root) {
        
        if(root == null)
            return new List<int>();
        
        var stack = new Stack<Node>();
        stack.Push(root);
        
        var result = new List<int>();
        
        while(stack.Count() > 0)
        {
            var current = stack.Pop();
            result.Add(current.val);
            
            foreach(var neighbour in current.children.Reverse())
                stack.Push(neighbour);
        }
        
        return result;
    }
}