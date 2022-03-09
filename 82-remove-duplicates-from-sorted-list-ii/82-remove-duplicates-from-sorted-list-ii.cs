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
    public ListNode DeleteDuplicates(ListNode head) 
    {
        if(head == null)
            return head;
        
        var dummy = new ListNode(200);
        dummy.next = head;
        var current = head;
        var prev = dummy;
        bool isSeq = false;
        while(current.next != null)
        {
            while(current.next != null && current.val == current.next.val)
            {
                current = current.next;
                isSeq = true;
            }
            
            if(current.next == null)
            {
                prev.next = null;
                break;
            }
            
            if(isSeq)
            {
                prev.next = current.next;
                isSeq = false;
                current = current.next;
                continue;
            }
            
            prev = current;
            current = current.next;
        }
        
        return dummy.next;
    }
}


















































// if(head is null)
//             return head;
        
//         bool isSeq = false;
//         int val = head.val;
//         var curr = head;
//         ListNode prev = null;
//         while(curr.next != null)
//         {
//             val = curr.val;
//             if(curr.next.val == val)
//             {
//                 isSeq = true;
//                 curr = curr.next;
//             }
//             else
//             {
//                 if(isSeq)
//                 {
//                     if(prev is null)
//                         head = curr.next;
//                     else
//                         prev.next = curr.next;

//                     curr = curr.next;
//                 }
//                 else
//                 {
//                     prev = curr;
//                     curr = curr.next;
//                 }
                
//                 isSeq = false;
//             }
//         }
        
//         if(isSeq)
//         {
//             if(prev is null)
//                 return null;
//             else
//                 prev.next = null;
//         }
        
//         return head;