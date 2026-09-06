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

public class Solution
{
    public void ReorderList(ListNode head)
    {
        var turtle = head;
        var hare = head;
        
        while (hare is not null && hare.next is not null)
        {
            hare = hare.next.next;
            turtle = turtle.next;
        }

        var current = turtle;
        var prev = (ListNode)null;
        
        while (current is not null)
        {
            var next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        current = head;
        var tail = prev;

        while (tail.next is not null)
        {
            var currentNext = current.next;
            var tailNext = tail.next;

            tail.next = current.next;
            current.next = tail;    

            current = currentNext;
            tail = tailNext;
        }
    }
}