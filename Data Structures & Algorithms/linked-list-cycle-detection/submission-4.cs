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
    public bool HasCycle(ListNode head) {
        if (head == null || head.next == null) return false;

        var turtle = head;
        var hare = head;

        while (hare != null && hare.next != null)
        {
            turtle = turtle.next;
            hare = hare.next.next;

            if (hare == turtle) return true;
        }

        return false;
    }
}