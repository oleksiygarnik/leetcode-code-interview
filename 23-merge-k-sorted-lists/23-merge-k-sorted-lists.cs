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
    public ListNode MergeKLists(ListNode[] lists) {
        var point = new ListNode(0);
        var head = point;

        var list = new List<int>();
        foreach(var current in lists)
        {
            var node = current;
            while(node != null)
            {
                list.Add(node.val);
                node = node.next;
            }
        }
        
        foreach(var item in list.OrderBy(x => x))
        {
            point.next = new ListNode(item);
            point = point.next;
        }
        
        return head.next;
    }
}