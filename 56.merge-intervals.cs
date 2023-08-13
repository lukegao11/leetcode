/*
 * @lc app=leetcode id=56 lang=csharp
 *
 * [56] Merge Intervals
 */

// @lc code=start
public class Solution {
    public int[][] Merge(int[][] intervals) {
        // Step 1: Sort the intervals array based on the start value of each interval
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        
        // Initialize a list to store the merged intervals
        List<int[]> resl = new();
        
        // Initialize variables to track the current merged interval's start and end
        int start = intervals[0][0];
        int end = intervals[0][1];
        
        // Step 2: Iterate through each interval in the sorted array
        foreach (int[] interval in intervals) {
            int currstart = interval[0];
            int currend = interval[1];
            
            // Check if the current interval's start is greater than the current merged interval's end
            if (currstart > end) {
                // If so, add the current merged interval to the result list
                resl.Add(new int[] { start, end });
                // Update the start and end to the values of the current interval
                start = currstart;
                end = currend;
            } else if (currend < start) {
                // If the current interval's end is less than the current merged interval's start,
                // add the current interval to the result list as it's separate
                resl.Add(new int[] { currstart, currend });
            } else {
                // If the current interval overlaps with the current merged interval,
                // update the start and end to encompass both intervals
                start = Math.Min(start, currstart);
                end = Math.Max(end, currend);
            }
        }
        
        // Add the last merged interval to the result list
        resl.Add(new int[] { start, end });
        
        // Convert the result list to a 2D array for the final output
        int[][] res = new int[resl.Count][];
        for (int i = 0; i < resl.Count; i++) {
            res[i] = new int[2];
        }
        for (int i = 0; i < resl.Count; i++) {
            res[i][0] = resl[i][0];
            res[i][1] = resl[i][1];
        }
        
        // Return the merged intervals
        return res;
    }
}
// @lc code=end

