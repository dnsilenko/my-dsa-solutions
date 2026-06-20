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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists == null || lists.Length == 0) return null;

        while (lists.Length > 1)
        {
            var list = new List<ListNode>();
            for (int i = 0; i < lists.Length; i += 2)
            {
                var list1 = lists[i];
                var list2 = i + 1 < lists.Length ? lists[i + 1] : null;

                list.Add(Merge(list1, list2));
            }

            lists = list.ToArray();
        } 

        return lists[0];
    }

    private ListNode Merge(ListNode list1, ListNode list2)
    {
        var list = new ListNode();
        var dummy = list;
        
        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val) 
            {
                dummy.next = list1;
                list1 = list1.next;
            }
            else 
            {
                dummy.next = list2;
                list2 = list2.next;
            }

            dummy = dummy.next;
        }    

        if (list1 != null) dummy.next = list1;
        if (list2 != null) dummy.next = list2;

        return list.next;
    }   
}