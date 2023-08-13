/*
 * @lc app=leetcode id=74 lang=csharp
 *
 * [74] Search a 2D Matrix
 */

// @lc code=start
public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length; // Get the number of rows in the matrix
        int n = matrix[0].Length; // Get the number of columns in the matrix
        int right, left;
        if (matrix[0][0] > target) return false; // If the target is smaller than the smallest element, return false
        
        // Loop through each row of the matrix
        for(int i = 0; i < m; i++){
            if (matrix[i][0] == target) return true; // If the first element in the row is the target, return true
            if (matrix[i][0] < target){
                right = n - 1; 
                left = 0;
                
                // Binary search within the current row
                while(right >= left){
                    int mid = left + (right - left)/2; // Calculate the middle index
                    if (matrix[i][mid] == target) return true; // If the middle element is the target, return true
                    else if (matrix[i][mid] < target){
                        left = mid + 1; // Adjust the left boundary if the middle element is smaller than the target
                    } else {
                        right = mid - 1; // Adjust the right boundary if the middle element is larger than the target
                    }
                }
            }
        }
        return false; // Return false if the target is not found in the matrix
    }
}
// @lc code=end

