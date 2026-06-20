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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int length = 0;
        var current = head;
        while (current != null) 
        {
            length++; current = current.next;
        }   

        current = head; var prev = (ListNode)null;
        while (current != null)
        {
            var next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }    

        if (n == 1) prev = prev.next;
        else
        {
            var node = prev;
            for (int i = 0; i < n - 2; i++)
            {
                node = node.next;
            }

            node.next = node.next.next;   
        }

        current = prev; var prev1 = (ListNode)null;
        while (current != null)
        {
            var next = current.next;
            current.next = prev1;
            prev1 = current;
            current = next;
        }    

        return prev1;
    }
}
