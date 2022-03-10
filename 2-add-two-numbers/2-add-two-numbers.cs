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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        var dummy = new ListNode(0);
        var tail = dummy;
        var count = 0;
        
        while(l1 != null && l2 != null)
        {
            var num = l1.val + l2.val + count;
            if(num/10 >= 1)
                count = 1;
            else
                count = 0;
            
            num = num % 10;
            
            tail.next = new ListNode(num);
            tail = tail.next;
            l1 = l1.next;
            l2 = l2.next;
        }
        
        if(l1 == null)
        {
            while(l2 != null)
            {
                var num = l2.val + count;
                if(num/10 == 1)
                    count = 1;
                else
                    count = 0;
                
                num = num % 10;
                
                tail.next = new ListNode(num);
                tail = tail.next;
                l2 = l2.next;
            }
        }
        
        if(l2 == null)
        {
            while(l1 != null)
            {
                var num = l1.val + count;
                if(num/10 == 1)
                    count = 1;
                else
                    count = 0;
                
                num = num % 10;
                
                tail.next = new ListNode(num);
                tail = tail.next;
                l1 = l1.next;
            }
        }
        
        if(count == 1)
            tail.next = new ListNode(count);
        
        return dummy.next;
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
//      var dummy = new ListNode(0);
//         var tail = dummy;
        
//         var count = 0;
//         while(l1 != null && l2 != null)
//         {
//             var sum = l1.val + l2.val + count;
//               if(sum/10 >= 1)
//               {
//                   sum = sum % 10;
//                 count = 1;
//               }
//             else{
//                 count = 0;
//             }
            
//             tail.next = new ListNode(sum);
//             tail = tail.next;
//             l1 = l1.next;
//             l2 = l2.next;
//         }
        
//         if(l1 == null)
//         {
//             while(l2 != null)
//             {
//                  var sum = l2.val + count;
//               if(sum/10 >= 1)
//               {
//                   sum = sum % 10;
//                 count = 1;
//               }
//             else{
//                 count = 0;
//             }
            
//             tail.next = new ListNode(sum);
//             tail = tail.next;
//             l2 = l2.next;
//             }
//         }
//         else{
//              while(l1 != null)
//             {
//                  var sum = l1.val + count;
//               if(sum/10 >= 1)
//               {
//                   sum = sum % 10;
//                 count = 1;
//               }
//             else{
//                 count = 0;
//             }
            
//             tail.next = new ListNode(sum);
//             tail = tail.next;
//             l1 = l1.next;
//             }
//         }
        
//         if(count == 1)
//             tail.next = new ListNode(1);
        
//         return dummy.next;
}

