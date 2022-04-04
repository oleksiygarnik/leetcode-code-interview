public class Solution {
    public ListNode SwapNodes(ListNode head, int k) {
         var current = head;
            int count = 0;

            while(current != null)
            {
                count++;
                current = current.next;
            }

            int firstElemIndex = k;
            int secondElemIndex = count - k + 1;
            current = head;
            ListNode firstNode = null;
            ListNode secondNode = null;

            int pos = 1;
            while (current != null)
            {
                if (pos == firstElemIndex)
                    firstNode = current;

                if (pos == secondElemIndex)
                    secondNode = current;

                current = current.next;
                pos++;
            }

            int tmp = firstNode.val;
            firstNode.val = secondNode.val;
            secondNode.val = tmp;

            return head;
    }
}