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
    public ListNode RotateRight(ListNode head, int k) 
    {
        if(head == null || k == 0)
            return head;
        
        var current = head;
        int count = 0;
        while(current != null)
        {
            count++;
            current = current.next;
        }
        
        k = k % count;
        if(k == 0)
            return head;
        
        var skip = count - k;
        current = head;
        ListNode prev = null;
        while(skip != 0)
        {
            skip--;
            prev = current;
            current = current.next;
        }
        
        prev.next = null;
        var result = current;
        while(current.next != null)
            current = current.next;
        
        current.next = head;
        
        return result;
    }
}