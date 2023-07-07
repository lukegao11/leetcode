/*
 * @lc app=leetcode id=141 lang=csharp
 *
 * [141] Linked List Cycle
 */

// @lc code=start

/**
* Definition for singly-linked list.
* public class ListNode {
*     public int val;
*     public ListNode next;
*     public ListNode(int x) {
*         val = x;
*         next = null;
*     }
* }
*/
public class Solution {
    public bool HasCycle(ListNode head) {
        //O(n^2)
        // ListNode curr = head;
        // if(curr.next == null) return false;
        // ListNode tmp = curr;
        // while(curr != null){
        //     while(tmp != null){
        //         if(tmp == curr){
        //             return true;
        //         }
        //         tmp = tmp.next;
        //     }
        //     curr = curr.next;
        // }
        // return false;

        //use hasht set
        //O(n) and O(n)
        // HashSet<ListNode> nodeset = new();
        // while(head != null){
        //     if(nodeset.Contains(head)){
        //         return true;
        //     }
        //     nodeset.Add(head);
        //     head = head.next;
        // }
        // return false;

        //T:O(n) S:O(1)
        //Floyd's cycle finding algo
        //if the fast one can catch the slower one
        //that means there is a circle
        if (head == null) return false;
        if (head.next == null) return false;

        ListNode fastpointer = head;
        ListNode slowpointer = head;
    
        while (fastpointer.next != null) {
            fastpointer = fastpointer.next.next;
            slowpointer = slowpointer.next;
            //must increment first
            //if not, always return true
            if(fastpointer == slowpointer){
                return true;
            }
        }  
        return false;

        
    }
}
// @lc code=end

