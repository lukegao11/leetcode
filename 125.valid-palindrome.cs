/*
 * @lc app=leetcode id=125 lang=csharp
 *
 * [125] Valid Palindrome
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(string s) {
        // Check if the input string is null or empty.
        if (string.IsNullOrEmpty(s)) {
            return true; // An empty string is considered a palindrome.
        }
        
        int start = 0; // Initialize a variable to track the start index.
        int last = s.Length - 1; // Initialize a variable to track the last index.
        
        // Iterate through the string from both ends until the pointers meet or cross.
        while (start <= last) {
            char currFirst = s[start]; // Get the character at the start index.
            char currLast = s[last]; // Get the character at the last index.
            
            // If the current character at the start index is not a letter or digit,
            // move the start index to the right.
            if (!char.IsLetterOrDigit(currFirst)) {
                start++;
            } else if (!char.IsLetterOrDigit(currLast)) {
                // If the current character at the last index is not a letter or digit,
                // move the last index to the left.
                last--;
            } else {
                // If both characters are letters or digits, compare them while ignoring case.
                if (char.ToLower(currFirst) != char.ToLower(currLast)) {
                    return false; // If they are not equal, it's not a palindrome.
                }
                start++; // Move the start index to the right.
                last--; // Move the last index to the left.
            }
        }
        
        // If the loop finishes without returning, the string is a palindrome.
        return true;
    }
}
// @lc code=end

