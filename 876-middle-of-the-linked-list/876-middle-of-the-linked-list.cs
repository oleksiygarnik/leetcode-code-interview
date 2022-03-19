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
    public ListNode MiddleNode(ListNode head) 
    {
        var slow_p = head;
        var fast_p = head;
        while(fast_p?.next != null)
        {
            slow_p = slow_p.next;
            fast_p = fast_p?.next?.next;
        }
        
        return slow_p;
    }
}