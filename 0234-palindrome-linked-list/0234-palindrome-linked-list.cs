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
    public bool IsPalindrome(ListNode head) 
    {
        var slow = head;
        var fast = head.next;
        while(fast?.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        
        slow.next = Reverse(slow.next);
        var secondPart = slow.next;
        
        var current = head;
        while(secondPart != null)
        {
            if(current.val != secondPart.val)
                return false;
            
            current = current.next;
            secondPart = secondPart.next;
        }
        
        return true;
    }
    

	// Reverse the LinkedList
	private ListNode Reverse(ListNode head){
		ListNode pre = null, cur = head, nxt = null;

		while(cur != null){
			nxt = cur.next;
			cur.next = pre;
			pre = cur;
			cur = nxt;
		}

		return pre;
	}
}