/*
 * @lc app=leetcode id=15 lang=csharp
 *
 * [15] 3Sum
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        // Create a list to store the resulting triplets.
        List<IList<int>> res = new();

        // Sort the input array in ascending order.
        Array.Sort(nums);

        // Iterate through the array to find potential triplets.
        for (int i = 0; i < nums.Length; i++) {
            // Skip duplicate elements to avoid duplicate triplets.
            if (i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }

            // Initialize the left pointer to the next element.
            int left = i + 1;

            // Initialize the right pointer to the last element.
            int right = nums.Length - 1;

            // Use a two-pointer approach to find triplets.
            while (right > left) {
                // Calculate the sum of the current triplet.
                int sum = nums[i] + nums[left] + nums[right];

                // If the sum is less than 0, move the left pointer to a larger element.
                if (sum < 0) {
                    left++;
                }
                // If the sum is greater than 0, move the right pointer to a smaller element.
                else if (sum > 0) {
                    right--;
                }
                // If the sum is 0, add the triplet to the result.
                else {
                    res.Add(new List<int> { nums[i], nums[left], nums[right] });

                    // Move the left pointer to the next distinct element.

                    while (left < right && nums[left] == nums[left + 1]) {
                        left++;
                    }
                    while (left < right && nums[right] == nums[right - 1]) {
                        right--;
                    }

                    left++;
                    right--;
                }
            }
        }

        // Return the list of triplets that sum up to zero.
        return res;
    }
}
// @lc code=end

