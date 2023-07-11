/*
 * @lc app=leetcode id=23 lang=csharp
 *
 * [23] Merge k Sorted Lists
 */

// @lc code=start



using System.Collections.Generic;
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

    //brute force O(nlogn) & O(n)
    //     List<int> l = new();

    //     for (int i = 0; i < lists.Length; i++)
    //     {
    //         ListNode ln = lists[i];
    //         while (ln != null)
    //         {
    //             l.Add(ln.val);
    //             ln = ln.next;
    //         }
    //     }
    //     l.Sort();

    //     ListNode prehead = new();
    //     ListNode pointer = prehead;

    //     foreach(int i in l){
    //         ListNode newNode = new(i);
    //         pointer.next = newNode;
    //         pointer = pointer.next;
    //     } 

    //     return prehead.next;

    // }

    // compare one by one
    // O(kn) & O(n)

    // int min_index = 0;
    // ListNode head = new ListNode(0);
    // ListNode h = head;
    // while (true)
    // {
    //     bool isBreak = true;
    //     int min = int.MaxValue; // Equivalent to Integer.MAX_VALUE in Java
    //     for (int i = 0; i < lists.Length; i++)
    //     {
    //         if (lists[i] != null)
    //         {
    //             if (lists[i].val < min)
    //             {
    //                 min_index = i;
    //                 min = lists[i].val;
    //             }
    //             isBreak = false;
    //         }
    //     }
    //     if (isBreak)
    //     {
    //         break;
    //     }
    //     ListNode a = new ListNode(lists[min_index].val);
    //     h.next = a;
    //     h = h.next;
    //     lists[min_index] = lists[min_index].next;
    // }
    // h.next = null;
    // return head.next;

    //use priority queue
    var pq = new PriorityQueue<ListNode, int>();

    for(int i = 0; i < lists.Length; i++){
        if(lists[i] != null) pq.Enqueue(lists[i], lists[i].val);
    }
    ListNode prehead = new();
    ListNode pointer = prehead;
    while(pq.Count > 0){
        ListNode newNode = pq.Dequeue();
        if(newNode.next != null){
            pq.Enqueue(newNode.next, newNode.next.val);
        }
        pointer.next = new ListNode(newNode.val, null);
        pointer = pointer.next;
    }
    return prehead.next;



    }

    


}
// @lc code=end

