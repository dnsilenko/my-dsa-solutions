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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var head = new ListNode();
        var current = head;

        while (list1 is not null && list2 is not null)
        {
            if (list1.val < list2.val) 
            {
                current.next = new ListNode(list1.val);
                list1 = list1.next;   
            }
            else
            {
                current.next = new ListNode(list2.val);
                list2 = list2.next; 
            }

            current = current.next;
        }   

        while (list1 is not null)
        {
            current.next = new ListNode(list1.val);
            list1 = list1.next; 

            current = current.next;
        }    

        while (list2 is not null)
        {
            current.next = new ListNode(list2.val);
            list2 = list2.next; 

            current = current.next;
        } 

        head = head.next;
        return head;
    }
}