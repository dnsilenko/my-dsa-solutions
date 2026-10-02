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
        var hare = head.next;

        while (hare is not null && hare.next is not null)
        {
            hare = hare.next.next;
            turtle = turtle.next;
        }  

        var prev = (ListNode)null;
        var current = turtle;

        while (current is not null)
        {
            var next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        var f = head;
        var s = prev;

        while (f is not null && s is not null)
        {
            var n1 = f.next;
            var n2 = s.next;

            f.next = s;
            s.next = n1;

            f = n1;
            s = n2;   
        }
    }
}
