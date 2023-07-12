/*
 * @lc app=leetcode id=19 lang=csharp
 *
 * [19] Remove Nth Node From End of List
 */

// @lc code=start
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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode pointer = head;
        ListNode pointer2 = head;
        int counter = 0;
        while(pointer != null){
            counter ++;
            pointer = pointer.next;
        }
        int pos = counter > n? counter - n: 0;
        if (pos == 0) return head.next; 
        for (int i = 0; i <= pos - 1; i++){
            if (i == pos - 1) {
                pointer2.next = pointer2.next.next;
                return head;
            }
            pointer2 = pointer2.next;
        }
        return head;
    }
}
// @lc code=end

