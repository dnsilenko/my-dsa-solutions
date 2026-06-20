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
    public void ReorderList(ListNode head) {
        
        var turtle = head; var hare = head.next;    
        while (hare != null && hare.next != null)
        {
            turtle = turtle.next;
            hare = hare.next.next;
        }

        var node = turtle.next;
        turtle.next = null;

        var current = node; var prev = (ListNode)null;
        while (current != null)
        {
            var next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        var first = head; var second = prev;
        while (second != null)
        {
            var t1 = first.next; var t2 = second.next;
            
            first.next = second;
            second.next = t1;

            first = t1; second = t2;
        }  

    }
}