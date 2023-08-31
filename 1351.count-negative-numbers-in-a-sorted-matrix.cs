/*
 * @lc app=leetcode id=1351 lang=csharp
 *
 * [1351] Count Negative Numbers in a Sorted Matrix
 */

// @lc code=start
public class Solution
{
    // public int CountNegatives(int[][] grid){
    //     int row_num = grid.GetLength(0);
    //     int col_num = grid[0].GetLength(0);
    //     int res = 0;
    //     for(int i = 0; i < row_num; i++){
    //         if(grid[i][0] < 0){
    //             res += col_num;
    //             continue;
    //         } else if (grid[i][col_num - 1] > 0) continue;
    //         int l = 0;
    //         int r = col_num - 1;
    //         while(l <= r){
    //             int m = (l + r) / 2;
    //             if (grid[i][m] < 0){
    //                 r = m - 1;
    //             } else {
    //                 l = m + 1;
    //             }
    //         }
    //         res += col_num - l;
    //     }
    //     return res;
    // }
    public int CountNegatives(int[][] grid) {
        int count = 0;
        int n = grid[0].Length;
        // Iterate on all rows of the matrix one by one.
        foreach (int[] row in grid) {
            // Using binary search find the index
            // which has the first negative element.
            int left = 0, right = n - 1;
            while (left <= right) {
                int mid = (right + left) / 2;
                if (row[mid] < 0) {
                    right = mid - 1;
                } else {
                    left = mid + 1;  
                }
            }
            // 'left' points to the first negative element,
            // which means 'n - left' is the number of all negative elements.
            count += (n - left);
        }
        return count;
    }

}
// @lc code=end




