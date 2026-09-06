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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        int length = 0;
        var current = head;

        while (current is not null)
        {
            current = current.next;
            length++;
        }          

        current = head;
        int number = length - n;
        
        if (number == 0) return head.next;

        for (int i = 1; i <= number; i++)
        {
            if (i == number)
            {
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }

        return head;
    }
}
