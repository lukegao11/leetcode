/*
 * @lc app=leetcode id=179 lang=csharp
 *
 * [179] Largest Number
 */

// @lc code=start
public class Solution {
    public string LargestNumber(int[] nums) {
        // Create an array of strings to hold the string representations of the input numbers
        string[] numstr = new string[nums.Length];
        
        // Convert each integer in the 'nums' array to its string representation
        for (int i = 0; i < nums.Length; i++) {
            numstr[i] = nums[i].ToString();
        }
        
        // Initialize an empty string to store the final result
        string res = "";
        
        // Sort the 'numstr' array based on a custom comparison logic
        // The comparison is based on concatenating strings and comparing the results
        Array.Sort(numstr, (a, b) => (b + a).CompareTo(a + b));
        
        // Iterate through the sorted 'numstr' array and append each string to the 'res'
        foreach (string i in numstr) {
            res += i;
        }
        
        // Return the concatenated string 'res', which represents the largest possible number
        return res;
    }
}
// @lc code=end

