/*
 * @lc app=leetcode id=167 lang=csharp
 *
 * [167] Two Sum II - Input Array Is Sorted
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int right = numbers.Length - 1;
        int left = 0;

        // two pointer
        // Iterate while the left pointer is less than the right pointer
        while (right > left)
        {
            // Calculate the sum of elements at left and right pointers
            int sum = numbers[left] + numbers[right];

            // If the sum matches the target, return the indices
            if (sum == target)
            {
                return new int[] { left + 1, right + 1 }; // Adding 1 because indices are 1-based
            }
            // If the sum is greater than the target, move the right pointer to the left
            else if (sum > target)
            {
                right--;
            }
            // If the sum is less than the target, move the left pointer to the right
            else
            {
                left++;
            }
        }

        // Return null if no pair with the target sum is found
        return null;
    }
}
// @lc code=end

