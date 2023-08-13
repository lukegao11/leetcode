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
    // Create a priority queue (min-heap) that stores ListNode objects with associated integer values.

    for (int i = 0; i < lists.Length; i++) {
        if (lists[i] != null)
            pq.Enqueue(lists[i], lists[i].val); 
    // Enqueue non-null ListNode objects from the 'lists' array into the priority queue with their respective values.
    // pq: [(1 -> 4 -> 5), (1 -> 3 -> 4), (2 -> 6)]
    // or pq: [1,1,2]
    // since the priority queue (pq) in this context does not contain the rest of the linked lists themselves. 
    // It only contains individual nodes from the linked lists, specifically the nodes that are currently being considered for merging.
    // each node stored in the priority queue represents the next node to be merged from 
    // one of the linked lists. When a node is dequeued from the priority queue, 
    // its corresponding linked list's progress advances to the next node (if available), 
    // and that next node is enqueued back into the priority queue for future consideration.
    }

    ListNode prehead = new ListNode(); 
    // Create a new ListNode called 'prehead' that will serve as a placeholder for the final merged list.
    ListNode pointer = prehead; 
    // Create a pointer 'pointer' initially pointing to 'prehead'.

    while (pq.Count > 0) {
        ListNode newNode = pq.Dequeue(); 
        // Dequeue the ListNode with the smallest value from the priority queue.

        if (newNode.next != null) {
            pq.Enqueue(newNode.next, newNode.next.val); 
            // If the dequeued ListNode has a next node, enqueue the next node with its value.
        }

        // Create a new ListNode with the value of the dequeued ListNode, and set its next pointer to null.
        pointer.next = new ListNode(newNode.val, null);
        
        pointer = pointer.next; 
        // Move the 'pointer' to the newly created node.
    }

    return prehead.next; 
    // Return the merged list starting from the node after 'prehead', which excludes the initial placeholder.



    }

    


}
// @lc code=end

