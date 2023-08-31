/*
 * @lc app=leetcode id=134 lang=csharp
 *
 * [134] Gas Station
 */

// @lc code=start
public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int answer = 0;          // Index of the potential starting gas station
        int totalgain = 0;       // Total accumulated gain from all stations
        int currgain = 0;        // Current accumulated gain along the way

        // Iterate through each gas station
        for (int i = 0; i < gas.Length; i++) {
            totalgain += gas[i] - cost[i]; // Calculate the overall gain

            // Calculate the current accumulated gain considering the current station
            currgain += gas[i] - cost[i];

            // If the current accumulated gain becomes negative (running out of gas),
            // reset the starting station and the current accumulated gain
            if (currgain < 0) {
                answer = i + 1;     // Set the next station as a potential starting point
                currgain = 0;       // Reset current accumulated gain
            }
        }

        // Return the index of the starting gas station if the total gain is non-negative,
        // indicating that there's a valid cycle that can be completed.
        // Otherwise, return -1 to indicate that it's not possible to complete a full cycle.
        return totalgain >= 0 ? answer : -1;
    }
}

// @lc code=end

