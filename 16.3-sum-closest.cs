/*
 * @lc app=leetcode id=16 lang=csharp
 *
 * [16] 3Sum Closest
 */

// @lc code=start
public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        int diff = int.MaxValue; // Initialize the difference variable to a large value
        int sz = nums.Length; // Get the length of the input array
        Array.Sort(nums); // Sort the array in ascending order
        
        for (int i = 0; i < sz && diff != 0; ++i) { 
            // Iterate through the array
            int low = i + 1; 
            // Initialize a pointer for the element after the current one
            int high = sz - 1; 
            // Initialize a pointer for the last element
            
            while (low < high) { 
            // While the low pointer is before the high pointer
                int sum = nums[i] + nums[low] + nums[high]; 
            // Calculate the sum of the three elements
                
                if (Math.Abs(target - sum) < Math.Abs(diff)) { 
            // Compare the absolute difference of the current sum with the previous difference
                    diff = target - sum; 
            // Update the difference if the current sum is closer to the target
                }
                
                if (sum < target) { 
            // If the sum is less than the target, move the low pointer to the right
                    ++low;
                } else { 
            // If the sum is greater than or equal to the target, move the high pointer to the left
                    --high;
                }
            }
        }
        
        return target - diff; // Return the closest sum to the target
    }
}
// @lc code=end

