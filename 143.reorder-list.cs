/*
 * @lc app=leetcode id=143 lang=csharp
 *
 * [143] Reorder List
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
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null) return;
        // Find the middle of the list
        ListNode preMid = FindMid(head);
        ListNode head1 = head;
        ListNode head2 = preMid.next; 
        preMid.next = null;
        head2 = ReverseList(head2);
        MergeList(head1, head2);

    }
    public ListNode FindMid(ListNode head){
        ListNode slow = head;
        ListNode fast = head;
        while(fast.next != null && fast.next.next != null){
            fast = fast.next.next;
            slow = slow.next;
        }
        return slow;
    }

    public ListNode ReverseList(ListNode l){
        ListNode prev = null;
        ListNode cur = l;
        while(cur != null){
            ListNode next = cur.next;
            cur.next = prev;
            prev = cur;
            cur = next;
        }
        return prev;
    }

    public ListNode MergeList(ListNode l1, ListNode l2){
        ListNode head = l1;
        ListNode tmp1, tmp2;
        while(l1 != null && l2 != null){
            tmp1 = l1.next;
            tmp2 = l2.next;
            l1.next = l2;
            l2.next = tmp1;
            l1 = tmp1;
            l2 = tmp2;
        }
        return head;
    }

}
// @lc code=end

