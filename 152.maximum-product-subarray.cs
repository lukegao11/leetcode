/*
 * @lc app=leetcode id=152 lang=csharp
 *
 * [152] Maximum Product Subarray
 */

// @lc code=start
public class Solution {
    public int MaxProduct(int[] nums) {
        // If the input array is empty, return 0, as there is no product to compute.
        if (nums.Length == 0) return 0;

        // Initialize variables to keep track of the maximum product ending at the current index (max_so_far),
        // the minimum product ending at the current index (min_so_far), and the overall maximum product found so far (result).
        int max_so_far = nums[0]; // Initialize to the first element of the array.
        int min_so_far = nums[0]; // Initialize to the first element of the array.
        int result = max_so_far; // Initialize the result to the first element of the array.

        // Iterate through the array starting from the second element (index 1)
        for (int i = 1; i < nums.Length; i++){

            // Get the current element.
            int curr = nums[i];

            // Calculate the temporary maximum product ending at the current index.
            // It is the maximum of three values: 
            // 1. The current element alone (to handle negative values).
            // 2. The maximum product ending at the previous index multiplied by the current element.
            // 3. The minimum product ending at the previous index multiplied by the current element.
            int temp_max = Math.Max(curr, Math.Max(max_so_far * curr, min_so_far * curr));

            // Update the minimum product ending at the current index.
            // It is the minimum of three values: 
            // 1. The current element alone (to handle negative values).
            // 2. The maximum product ending at the previous index multiplied by the current element.
            // 3. The minimum product ending at the previous index multiplied by the current element.
            min_so_far = Math.Min(curr, Math.Min(max_so_far * curr, min_so_far * curr));

            // Update the maximum product ending at the current index.
            max_so_far = temp_max;

            // Update the overall maximum product found so far by taking the maximum between the current max_so_far and the result.
            result = Math.Max(max_so_far, result);
        }

        // Return the overall maximum product found during the iteration.
        return result;
    }
}
// @lc code=end

