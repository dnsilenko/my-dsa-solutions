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
    public bool HasCycle(ListNode head)
    {
        if (head is null) return false;

        var turtle = head;
        var hare = head.next;

        while (hare is not null && hare.next is not null)
        {
            if (hare == turtle) return true;

            turtle = turtle.next;
            hare = hare.next.next;
        }   

        return false;
    }
}