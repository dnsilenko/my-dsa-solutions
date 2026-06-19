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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null && list2 == null) return null;
        else if (list2 == null) return list1;
        else if (list1 == null) return list2;

        var head = new ListNode();
        var current = head;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val) 
            {
                current.val = list1.val;
                current.next = new ListNode();
                current = current.next;

                list1 = list1.next;
            }   
            else 
            {
                current.val = list2.val;
                current.next = new ListNode();
                current = current.next;

                list2 = list2.next;
            }
        }    
        
        while (list1 != null)
        {
            current.val = list1.val;
            if (list1.next != null)
            {
                current.next = new ListNode();
                current = current.next;
            }

            list1 = list1.next;  
        } 

        while (list2 != null)
        {
            current.val = list2.val;
            if (list2.next != null)
            {
                current.next = new ListNode();
                current = current.next;
            }
            
            list2 = list2.next;  
        } 

        return head; 
    }
}