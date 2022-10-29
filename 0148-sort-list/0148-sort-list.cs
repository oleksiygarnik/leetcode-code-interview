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
public class Solution {
    public ListNode SortList(ListNode head) 
    {
         if(head?.next == null)
            return head;
        
        var slow = head;
        var fast = head;
        ListNode previous = null;
        
        while(fast?.next != null)
        {
            previous = slow;
            slow = slow.next;
            fast = fast.next.next;
        }
        
        previous.next = null;
        
        var left = SortList(head);
        var right = SortList(slow);
        
        return Merge(left, right);
    }
    
    private ListNode Merge(ListNode left, ListNode right)
    {
        var dummy = new ListNode(0);
        var tail = dummy;
        
        while(left != null && right != null)
        {
            if(left.val < right.val)
            {
                tail.next = left;
                left = left.next;
            }
            else
            {
                tail.next = right;
                right = right.next;
            }
            
            tail = tail.next;
        }
        
        if(left is null)
            tail.next = right;
        else
            tail.next = left;
        
        return dummy.next;
    }
}