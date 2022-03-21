/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
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
    public bool IsSubPath(ListNode head, TreeNode root) 
    {
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        
        while(stack.Count() > 0)
        {
            var current = stack.Pop();
            
            if(current.val == head.val && IsContains(current, head))
                return true;
            
            if(current.left != null)
                stack.Push(current.left);
            
            if(current.right != null)
                stack.Push(current.right);
        }
        
        return false;
    }
    
    private bool IsContains(TreeNode treeNode, ListNode listNode)
    {
        if(listNode is null)
            return true;
        
        return treeNode?.val == listNode?.val && (IsContains(treeNode.left, listNode.next) || IsContains(treeNode.right, listNode.next));
    }
}