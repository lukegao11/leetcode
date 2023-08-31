/*
 * @lc app=leetcode id=57 lang=csharp
 *
 * [57] Insert Interval
 */

// @lc code=start
public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        int start = newInterval[0]; // Get the start of the new interval
        int end = newInterval[1]; // Get the end of the new interval
        List<int[]> list = new(); // Create a list to store merged intervals
        
        // Iterate through each interval in the input array
        foreach (int[] interval in intervals){
            int currstart = interval[0]; // Get the start of the current interval
            int currend = interval[1]; // Get the end of the current interval
            
            // Check if the current interval is after the new interval
            if(currstart > end){
                list.Add(new int[]{start, end}); 
                // Add the merged interval to the list
                start = currstart; 
                // Set the start and end to the current interval's values
                end = currend; 
            } 
            // Check if the current interval is before the new interval
            else if (currend < start) {
                list.Add(new int[]{currstart, currend}); 
                // Add the current interval to the list
            } 
            // If there's an overlap between the current interval and the new interval
            else {
                start = Math.Min(currstart, start); 
                // Update the start to the minimum of both starts
                end = Math.Max(currend, end); 
                // Update the end to the maximum of both ends
            }
        }
        
        list.Add(new int[]{start, end}); // Add the last merged interval to the list
        
        int[][] res = new int[list.Count][]; // Create a new 2D array for the result
        for(int i = 0; i<list.Count; i++){
            res[i] = new int[2]; // Initialize each inner array with 2 elements
        }
        
        // Copy the merged intervals from the list to the result array
        for(int i = 0; i<list.Count; i++){
            res[i][0] = list[i][0];
            res[i][1] = list[i][1]; 
        }
        
        return res; // Return the merged intervals
    }    
}
// @lc code=end

