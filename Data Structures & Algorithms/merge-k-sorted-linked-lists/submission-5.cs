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
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists.Length == 0) return null;
        var result = new List<ListNode>(lists);

        while (result.Count > 1)
        {
            var list = new List<ListNode>(); 
            for (int i = 1; i < result.Count; i += 2)
            {
                var merged = MergeTwoLists(result[i - 1], result[i]);
                list.Add(merged);
            }

            if (result.Count % 2 != 0) list.Add(result[result.Count - 1]);

            result = list;
        }

        return result[0];
    } 

    private ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var dummy = new ListNode();
        var current = dummy;

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

        if (list1 is not null) current.next = list1;
        else current.next = list2;

        return dummy.next;  
    }
}