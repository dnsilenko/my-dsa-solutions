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
        ListNode turtle = head, hare = head.next;      
        while (hare is not null && hare.next is not null)
        {
            turtle = turtle.next;
            hare = hare.next.next;
        }   

        ListNode current = turtle, prev = null;
        while (current is not null)
        {
            var next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        ListNode p1 = head, p2 = prev;
        while (p1 is not null && p2 is not null)
        {
            var next1 = p1.next; // 4
            var next2 = p2.next; // null

            p1.next = p2; 
            p2.next = next1; // 4

            p1 = next1;
            p2 = next2;
        }
    }
}



























