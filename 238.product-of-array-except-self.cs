/*
 * @lc app=leetcode id=238 lang=csharp
 *
 * [238] Product of Array Except Self
 */

// @lc code=start
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] res = new int[n];
        
        // Initialize the first element of the result array to 1
        res[0] = 1;

        // Calculate the product of all elements to the left of the current element
        // and store it in the result array
        for (int i = 1; i < n; i++) {
            res[i] = res[i - 1] * nums[i - 1];
        }

        // Initialize a variable to keep track of the product of all elements to the right of the current element
        int right = 1;

        // Calculate the product of all elements to the right of the current element
        // and multiply it with the corresponding value in the result array
        // This will give the final result (product of all elements except the current element)
        for (int i = n - 1; i >= 0; i--) {
            res[i] *= right; // Multiply the product of elements on the left with the product of elements on the right
            right *= nums[i]; // Update the product of elements on the right
        }

        // Return the final result array
        return res;
    }
}





// @lc code=end

