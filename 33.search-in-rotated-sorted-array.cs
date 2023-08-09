/*
 * @lc app=leetcode id=33 lang=csharp
 *
 * [33] Search in Rotated Sorted Array
 */

// @lc code=start
public class Solution {
    public int Search(int[] nums, int target) {
                int n = nums.Length;
        
        // Check if the target is the first element
        if (nums[0] == target) return 0;
        
        int right = n - 1;
        int left = 0;
        
        // Binary search loop
        while (right >= left){
            int mid = (right + left) / 2;
            
            // Check if the middle element is the target
            if (nums[mid] == target) return mid;

            // If the middle element is smaller than the left element, it means the rotation point is in the left half.
            if (nums[mid] < nums[left]){
                // Check if the target is within the sorted right half
                if (target > nums[mid] && target <= nums[right]){
                    left = mid + 1; // Search in the right half
                } else {
                    right = mid - 1; // Search in the left half
                }
            } else {
                // If the middle element is greater than or equal to the left element, it means the rotation point is in the right half.
                // Check if the target is within the sorted left half
                if (target < nums[mid] && target >= nums[left]){
                    right = mid - 1; // Search in the left half
                } else {
                    left = mid + 1; // Search in the right half
                }
            }
        }
        
        // If target is not found
        return -1;
    }
}
// @lc code=end

