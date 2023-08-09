/*
 * @lc app=leetcode id=53 lang=csharp
 *
 * [53] Maximum Subarray
 */

// @lc code=start
public class Solution {
    public int MaxSubArray(int[] nums) {
        // Initialize variables to keep track of the current subarray sum and the maximum subarray sum
        int curSub = nums[0]; // Initialize to the first element of the array
        int maxSub = nums[0]; // Initialize to the first element of the array

        // Iterate through the array starting from the second element (index 1)
        for (int i = 1; i < nums.Length; i++){
            // Calculate the current subarray sum by taking the maximum between the current element alone
            // and the sum of the current element with the previous subarray sum.
            // This ensures we are either extending the previous subarray or starting a new subarray at the current index.
            curSub = Math.Max(curSub + nums[i], nums[i]);

            // Update the maximum subarray sum by taking the maximum between the current subarray sum and the maximum subarray sum so far.
            // This way, we keep track of the overall maximum subarray sum encountered during the iteration.
            maxSub = Math.Max(curSub, maxSub);
        }

        // Return the maximum subarray sum found during the iteration.
        return maxSub;
    }
}
// @lc code=end

