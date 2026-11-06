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
            turtle = turtle.next;
            hare = hare.next.next;
        }   

        var current = turtle;
        ListNode prev = null;

        while (current is not null)
        {
            var next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        var p1 = head;
        var p2 = prev;
        while (p1.next is not null && p2.next is not null)
        {
            var next1 = p1.next;
            var next2 = p2.next;

            p1.next = p2;
            p2.next = next1;

            p1 = next1;
            p2 = next2;
        }

        p2 = p1 ?? p2;  
    }
}



























