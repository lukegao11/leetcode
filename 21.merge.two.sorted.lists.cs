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
    //same thing as merge sort 
    //use another ListNode 
    //and another pointer for the new ListNode
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode pointer1 = list1;
        ListNode pointer2 = list2;
        ListNode prehead = new();
        ListNode pointer3 = prehead;
        while(pointer1 != null && pointer2 != null){
                if(pointer1.val <= pointer2.val) {
                    pointer3.next = pointer1;
                    pointer1 = pointer1.next;
                } else {
                    pointer3.next = pointer2;
                    pointer2 = pointer2.next;
                }
                pointer3 = pointer3.next;
            }
            pointer3.next = pointer1 == null ? pointer2 : pointer1;
            return prehead.next;
    }

}