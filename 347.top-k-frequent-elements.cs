/*
 * @lc app=leetcode id=347 lang=csharp
 *
 * [347] Top K Frequent Elements
 */

// @lc code=start
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Create a priority queue to store elements with their negated frequencies.
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

        // Create a dictionary to store the frequencies of elements.
        Dictionary<int, int> freq = new Dictionary<int, int>();
        
        // Count the frequencies of elements in the 'nums' array.
        foreach(int i in nums) {
            if (freq.ContainsKey(i))
                freq[i]++;
            else
                freq[i] = 1;
        }

        // Enqueue elements into the priority queue with negated frequencies.
        foreach (var key in freq) {
            pq.Enqueue(key.Key, -key.Value); // Negate the frequency for max-heap behavior.
        }

        // Create an array to store the top 'k' frequent elements.
        int[] res = new int[k];

        // Dequeue 'k' elements from the priority queue.
        for (int i = 0; i < k; i++) {
            res[i] = pq.Dequeue();
        }

        // Return the array of top 'k' frequent elements.
        return res;
    }
}
// @lc code=end

