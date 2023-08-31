/*
 * @lc app=leetcode id=283 lang=csharp
 *
 * [283] Move Zeroes
 */

// @lc code=start
public class Solution {
    public void MoveZeroes(int[] nums) {
        int snowballsize = 0; // Initialize a counter to keep track of the size of the "snowball" of zeros.

        // Iterate through the array.
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) {
                snowballsize++; // If the current element is zero, increment the snowball size.
            } else {
                int t = nums[i]; // Store the current non-zero element in a temporary variable.
                nums[i] = 0; // Set the current element to zero.
                nums[i - snowballsize] = t; // Move the non-zero element to its correct position, shifting it by the snowball size.
            }
        }
    }
}
// @lc code=end

