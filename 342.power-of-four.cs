/*
 * @lc app=leetcode id=342 lang=csharp
 *
 * [342] Power of Four
 */

// @lc code=start
public class Solution
{
    public bool IsPowerOfFour(int num)
    {
        
        // if (num == 0) return false;
        // while (num % 4 == 0) num /= 4;
        // return num == 1;

        //bitwise
        return (num > 0) && ((num & (num - 1)) == 0) && ((num & 0xaaaaaaaa) == 0);
    }
}
// @lc code=end

