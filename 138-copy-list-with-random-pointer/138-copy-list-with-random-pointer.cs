/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) 
    {    
        if(head is null)
            return null;
        
        var storage = new Dictionary<Node, Node>();

        storage[head] = new Node(head.val);
        var result = storage[head];
        
        while(head != null)
        {
            if(head.next != null)
            {
                if(!storage.ContainsKey(head.next))
                    storage[head.next] = new Node(head.next.val);
                
                storage[head].next = storage[head.next];
            }
            
            if(head.random != null)
            {
                if(!storage.ContainsKey(head.random))
                    storage[head.random] = new Node(head.random.val);
                
                storage[head].random = storage[head.random];
            }
            
            if(!storage.ContainsKey(head))
                 storage[head] = new Node(head.val);
                
            head = head.next;
        }
        
        return result;
    }
}