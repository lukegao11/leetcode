/*
 * @lc app=leetcode id=438 lang=csharp
 *
 * [438] Find All Anagrams in a String
 */

// @lc code=start
public List<int> FindAnagrams(string s, string p)
{
    List<int> list = new List<int>();

    // Check for null or empty strings or invalid lengths
    if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(p) || s.Length < p.Length)
    {
        return list;
    }

    // Record character frequencies for string 'p'
    int[] freq = new int[26];

    // Count the frequencies of characters in string 'p'
    foreach (char c in p.ToCharArray())
    {
        freq[c - 'a']++;
    }

    // Initialize window pointers and counters
    int left = 0;
    int right = 0;
    int charsleft = p.Length; // Number of characters left to match anagram
    int windowsize = p.Length - 1; // Window size for checking anagrams
    int strlen = s.Length; // Length of the input string

    // Slide the window while processing characters in 's'
    while (right < strlen)
    {
        // Check if the current character at 'right' is required for anagram
        if (freq[s[right] - 'a'] > 0)
        {
            charsleft--; // Decrease the count of characters left to match

            // Check if all required characters are matched
            if (charsleft == 0)
            {
                // Anagram found, add the starting index 'left' to the list
                list.Add(left);
            }
        }

        // Update character frequency for the processed character
        freq[s[right] - 'a']--;

        // Slide the window when the window size is reached
        if (right - left == windowsize)
        {
            // Check if the character at 'left' was part of the required characters
            if (freq[s[left] - 'a'] >= 0)
            {
                charsleft++; // Increment the count of characters left to match
            }

            // Restore character frequency for the character at 'left'
            freq[s[left] - 'a']++;

            // Move the window by incrementing 'left' and 'right'
            left++;
            right++;
        }
        else
        {
            right++; // Expand the window by moving 'right'
        }
    }

    return list; // Return the list of starting indices of anagrams
}
// @lc code=end

